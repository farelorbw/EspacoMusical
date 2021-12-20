using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using espacomusical.Models;

namespace espacomusical.Models
{
    public class AgendaController : Controller
    {

        //controller: objetivo é ter as rotas com minhas actions. - CRUD

        public IActionResult ListaAgenda()
        {
            AgendaRepository ur = new AgendaRepository();
            List<Agenda> listaDePacotesTuristicos = ur.ListarAgenda();
            return View(listaDePacotesTuristicos);
        }
        public IActionResult CadastroAgenda()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CadastroAgenda(Agenda Ag)

        {

            AgendaRepository ur = new AgendaRepository();
            ur.InserirAgenda(Ag);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();

        }

        public IActionResult RemoverAgenda(int Id)
        {

            AgendaRepository ur = new AgendaRepository();
            Agenda AgLocalizado = ur.BuscarPorIdAgenda(Id);
            ur.ExcluirAgenda(AgLocalizado);
            return RedirectToAction("ListaAgenda","Agenda");

        }

        public IActionResult EditarAgenda(int Id)
        {

            AgendaRepository ur = new AgendaRepository();
            Agenda AgLocalizado = ur.BuscarPorIdAgenda(Id);
            return View(AgLocalizado);
        }

        [HttpPost]

       public IActionResult EditarAgenda(Agenda Ag)
        {
            AgendaRepository ur = new AgendaRepository();
            ur.AlterarAgenda(Ag);
            return RedirectToAction("ListaAgenda","Agenda");

        }
    }
}