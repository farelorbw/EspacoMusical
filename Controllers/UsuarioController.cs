using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using espacomusical.Models;

namespace espacomusical.Models
{
    public class UsuarioController : Controller
    {

        //controller: objetivo é ter as rotas com minhas actions. - CRUD

        public IActionResult Lista()
        {
            if (HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login", "Usuario");
            }
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> listaDeUsuarios = ur.Listar();
            return View(listaDeUsuarios);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Cadastro(Usuario user)

        {

            UsuarioRepository ur = new UsuarioRepository();
            ur.Inserir(user);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();

        }

        public IActionResult Remover(int Id)
        {
             if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login","Usuario");
            }
          
            UsuarioRepository ur = new UsuarioRepository();
            Usuario userLocalizado = ur.BuscarPorId(Id);
            ur.Excluir(userLocalizado);
            return RedirectToAction("Lista", "Usuario");

        }
        

        public IActionResult Editar(int Id)
        {

            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            UsuarioRepository ur = new UsuarioRepository();
            Usuario userLocalizado = ur.BuscarPorId(Id);
            return View(userLocalizado);
        }

        [HttpPost]

        public IActionResult Editar(Usuario user)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Alterar(user);
            return RedirectToAction("Lista", "Usuario");

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(Usuario user)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioEncontrado = ur.ValidarLogin(user);

            if (usuarioEncontrado == null)
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
            else
            {
                // iremos gravar na sessão as nossas credenciais.
                HttpContext.Session.SetInt32("IdUsuario", usuarioEncontrado.Id);
                HttpContext.Session.SetString("NomeUsuario", usuarioEncontrado.Nome);

                return RedirectToAction("Lista", "Usuario"); //action, controller
            }


        }

        public IActionResult Logout()
        {
            //limpar os dados da sessão.
            HttpContext.Session.Clear();

            return View("Login");
        }

    }
}