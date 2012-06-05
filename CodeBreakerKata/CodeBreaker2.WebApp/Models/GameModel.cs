using System.ComponentModel.DataAnnotations;

namespace CodeBreaker.WebApp.Models
{
    public class GameModel
    {
        [Required]
        [Display(Name = "Numero")]
        public int NumeroIngresado { get; set; }

        public int NumeroCorrecto { get; set; }

        [Display(Name = "Pista")]
        public string Pista { get; set; }

    }
}