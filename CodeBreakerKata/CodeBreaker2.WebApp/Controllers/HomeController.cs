using System.Web.Mvc;

namespace CodeBreaker.WebApp.Controllers
{
    public class HomeController : Controller
    {
        Game _juego = new Game();

        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenido al Code Breaker";
            _juego = new Game();
            _juego.NuevoNumero();
            return View();
        }

        public ActionResult Jugar()
        {
            ViewBag.Message = "Arriesga un codigo";
            _juego.NuevoNumero();
            return View();
        }

        [HttpPost]
        public ActionResult Jugar(int numeroIngresado)
        {
            _juego.ProbarNumero(numeroIngresado);
            if (_juego.Gane)
                return Ganaste();
            return View();
        }

        public ActionResult Ganaste()
        {
            ViewBag.Message = "GANASTE !!! el numero correcto era : " + _juego.NumeroCorrecto;
            return View();
        }

        public int NumeroCorrecto
        {
            get { return _juego.NumeroCorrecto; }
            set
            {
                _juego.NumeroCorrecto = value;
            }
        }

        public string Pista
        {
            get { return _juego.Pista; }
        }
    }
}
