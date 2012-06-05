using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBreaker
{
    public class Game
    {
        public void NuevoNumero()
        {
            NumeroCorrecto = (new Random()).Next(1000, 9999);
        }

        public int NumeroCorrecto { get; set; }

        public void ProbarNumero(int numeroIngresado)
        {
            string numero = numeroIngresado.ToString("G");
            string numeroCorrecto = NumeroCorrecto.ToString("G");

            var coincidenciasExactas = encontrarCoincidenciasExactas(numeroCorrecto, numero);
            var coincidenciasNoExactas = encontrarCoincidenciasNoExactas(numeroCorrecto, numero, coincidenciasExactas);
            
            GenerarPista(coincidenciasNoExactas, coincidenciasExactas);

            Gane = VerificarEstadoDelJuego(coincidenciasExactas);
        }

        private void GenerarPista(List<int> coincidenciasNoExactas, List<int> coincidenciasExactas)
        {
            Pista = string.Empty;
            if (coincidenciasExactas.Count > 0 || coincidenciasNoExactas.Count > 0)
            {
                Pista = string.Empty.PadLeft(coincidenciasExactas.Count, 'X') +
                        string.Empty.PadLeft(coincidenciasNoExactas.Count, '_');
            }
        }

        private bool VerificarEstadoDelJuego(List<int> coincidenciasExactas)
        {
            return coincidenciasExactas.Count == NumeroCorrecto.ToString("G").Length;
        }

        private List<int> encontrarCoincidenciasExactas(string numeroCorrecto, string numeroIngresado)
        {
            List<int> coincidencias = new List<int>();

            for (int i = 0; i < numeroIngresado.Length; i++)
            {
                if (numeroCorrecto[i] == numeroIngresado[i])
                {
                    coincidencias.Add(numeroIngresado[i]);
                }
            }
            return coincidencias;
        }

        private List<int> encontrarCoincidenciasNoExactas(string numeroCorrecto, string numeroString, List<int> coincidenciasExactas)
        {
            List<int> coincidencias = new List<int>();

            for (int i = 0; i < numeroString.Length; i++)
            {
                if (numeroCorrecto.Contains(numeroString[i])
                    && numeroCorrecto[i] != numeroString[i]
                    && !coincidenciasExactas.Contains(numeroString[i]))
                {
                    coincidencias.Add(numeroString[i]);
                }
            }
            return coincidencias;
        }

        public bool Gane { get; set; }

        public string Pista { get; set; }
    }
}
