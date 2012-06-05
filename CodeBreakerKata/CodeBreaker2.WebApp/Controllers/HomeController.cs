using System.Web.Mvc;
using CodeBreaker.WebApp.Models;

namespace CodeBreaker.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public GameModel Model = new GameModel();

        Game _juego;

        public ActionResult Index()
        {
            _juego = new Game();

            ViewBag.Message = "Bienvenido al Code Breaker";
            TempData["Juego"] = _juego;

            return View();
        }

        public ActionResult Jugar()
        {
            _juego = TempData["Juego"] as Game;
            
            _juego.NuevoNumero();
            Model.NumeroCorrecto = _juego.NumeroCorrecto;

            ViewBag.Message = "Arriesga un codigo";
            TempData["Juego"] = _juego;
            
            return View(Model);
        }

        [HttpPost]
        public ActionResult Jugar(int numeroIngresado)
        {
            _juego = TempData["Juego"] as Game;

            _juego.ProbarNumero(numeroIngresado);
            Model.Pista = _juego.Pista;
            if (_juego.Gane)
            {
                Ganaste();
                return RedirectToAction("Ganaste", "Home");
            }

            TempData["Juego"] = _juego;

            return View(Model);
        }

        public ActionResult Ganaste()
        {
            _juego = TempData["Juego"] as Game;

            ViewBag.Message = "GANASTE !!! el numero correcto era : " + _juego.NumeroCorrecto;

            return View();
        }

        public void EstablecerNumeroCorrecto(int numeroCorrecto)
        {
            _juego.NumeroCorrecto = numeroCorrecto;
            Model.NumeroCorrecto = numeroCorrecto;
        }

    }
}
