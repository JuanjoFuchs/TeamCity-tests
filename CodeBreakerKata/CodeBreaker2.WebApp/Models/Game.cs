using System.ComponentModel.DataAnnotations;

namespace CodeBreaker.WebApp.Models
{
    public class Game
    {
        [Required]
        [Display(Name = "Arriesga un codigo")]
        public int NumeroIngresado { get; set; }

        public CodeBreaker.Game Juego { get; set; }

    }
}