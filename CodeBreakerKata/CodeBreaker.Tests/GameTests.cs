using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace CodeBreaker.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void DeberiaGenerarUnNumeroAlAzar()
        {
            Game juego = new Game();
            juego.NuevoNumero();
            Assert.AreEqual(4, juego.NumeroCorrecto.ToString("G").Length);
        }

        [Test]
        public void DeberiaVerificarQueGaneSiIngreso1452YElNumeroCorrectoEs1452()
        {
            Game juego = new Game();
            juego.NumeroCorrecto = 1452;
            juego.ProbarNumero(1452);
            Assert.That(juego.Gane);
        }

        [Test]
        public void DeberiaRetornarPistaXXSiIngreso1452YElNumeroCorrectoEs8453()
        {
            Game juego = new Game();
            juego.NumeroCorrecto = 8453;
            juego.ProbarNumero(1452);
            Assert.AreEqual("XX", juego.Pista);
        }

        [Test]
        public void DeberiaRetornarNadaSiIngreso1235YElNumeroCorrectoEs4789()
        {
            Game juego = new Game();
            juego.NumeroCorrecto = 4789;
            juego.ProbarNumero(1235);
            Assert.AreEqual("", juego.Pista);
        }
    }
}
