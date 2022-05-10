using Aula_09_05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula_09_05.Controllers
{
    public class EquipeController : Controller
    {
        
        //ActionResult representam os vários códigos HTTP

        //instanciando.
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = Reserva de espaço para armazenar informações para recuperar na VIEW.

            //ViewBag = tem a função de "carregar as informações do controller para a VIEW.
            
            ViewBag.Equipes = equipeModel.LerEquipes();
            
            return View();
        }
    }
}
