using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CodeBreaker.WebApp.Controllers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CodeBreaker2.Specs
{
    [Binding]
    public class StepDefinitions
    {
        private HomeController _controller = null;
        private ActionResult _result = null;

        [Given(@"Ingreso a la aplicación")]
        public void DadoIngresoALaAplicacion()
        {
            _controller = new HomeController();
            _result = _controller.Index();
        }

        [Then(@"Debería ver el mensaje ""Bienvenido al Code Breaker""")]
        public void EntoncesDeberiaVerElMensajeBienvenidoAlCodeBreaker()
        {
            Assert.AreEqual("Bienvenido al Code Breaker", _controller.ViewData["Message"]);
        }

        [Given(@"Presiono el boton nuevo juego")]
        [When(@"Presiono el boton nuevo juego")]
        public void CuandoPresionoElBotonNuevoJuego()
        {
            _result = _controller.Jugar();
        }

        [Then(@"Debería ver el mensaje ""Arriesga un codigo""")]
        public void EntoncesDeberiaVerElMensajeArriesgaUnCodigo()
        {
            Assert.IsNotNull(_result);
            Assert.AreEqual("Arriesga un codigo", _controller.ViewData["Message"]);
        }

        [Then(@"Debería generar el numero al azar de cuatro digitos")]
        public void EntoncesDeberiaGenerarElNumeroAlAzarDeCuatroDigitos()
        {
            Assert.That(_controller.Model.NumeroCorrecto > 999);
            Assert.That(_controller.Model.NumeroCorrecto < 10000);
        }

        [Given(@"El numero correcto es (.*)")]
        public void CuandoElNumeroCorrectoEs(string numeroCorrecto)
        {
            _controller.EstablecerNumeroCorrecto(Int32.Parse(numeroCorrecto));
        }

        [When(@"Pruebo con (.*)")]
        public void CuandoPrueboCon(string numeroIngresado)
        {
            _result = _controller.Jugar(Int32.Parse(numeroIngresado));
        }

        [Then(@"Debería ver esta (.*)")]
        public void EntoncesDeberiaVerEstaPista(string pista)
        {
            Assert.AreEqual(pista, _controller.Model.Pista);
        }

        [Then(@"Debería ver el mensaje ""GANASTE !!! el numero correcto era : 4152""")]
        public void EntoncesDeberiaVerElMensajeGanaste()
        {
            Assert.AreEqual("GANASTE !!! el numero correcto era : 4152", _controller.ViewData["Message"]);
        }
    }
}
