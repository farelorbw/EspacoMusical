using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using espacomusical.Models;

namespace espacomusical.Models
{
    public class FaleConoscoController : Controller
    {

        //controller: objetivo é ter as rotas com minhas actions. - CRUD

        public IActionResult ListaFaleConosco()
        {
            FaleConoscoRepository ur = new FaleConoscoRepository();
            List<FaleConosco> listaDeFaleConosco = ur.ListarFaleConosco();
            return View(listaDeFaleConosco);
        }
        public IActionResult CadastroFaleConosco()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CadastroFaleConosco(FaleConosco Fc)

        {

            FaleConoscoRepository ur = new FaleConoscoRepository();
            ur.InserirFaleConosco(Fc);
            ViewBag.Mensagem = "Recebemos sua solicitação! Retornaremos assim que possível!";
            return View();

        }

        public IActionResult RemoverFaleConosco(int Id)
        {

            FaleConoscoRepository ur = new FaleConoscoRepository();
            FaleConosco FcLocalizado = ur.BuscarPorIdFaleConosco(Id);
            ur.ExcluirFaleConosco(FcLocalizado);
            return RedirectToAction("ListaFaleConosco","FaleConosco");

        }

    }
}