using Aula_09_05.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Cadastrar(IFormCollection form)
        {
            //criar um objeto equipe a partir do frontend.
            // frontend = IFormCollection
            
            Equipe novaEquipe = new Equipe();

            novaEquipe.idEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            //chamar a função CRIAR passando um objeto do tipo EQUIPE.
            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.LerEquipes();

            return LocalRedirect("~/Equipe");
        }
    }
}
