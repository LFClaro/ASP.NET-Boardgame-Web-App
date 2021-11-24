using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    public class BoardGame
    {
        [Key]
        public int BoardGameId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter minimum number of players.")]
        [Range(1, 999, ErrorMessage = "Number of players must be bigger than zero.")]
        public int NumberOfPlayersMin { get; set; }
        [Required(ErrorMessage = "Please enter maximum number of players.")]
        [Range(1, 999, ErrorMessage = "Number of players must be bigger than zero.")]
        public int NumberOfPlayersMax { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter playing time.")]
        public string Playing_Time { get; set; }
        [Range(0, 99, ErrorMessage = "Age must be between {1} and {2}.")]
        public int MinAge { get; set; }

        public int Quantity { get; set; }

        public virtual Rental Rental { get; set; }
    }
}
