using Final_project.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_project.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }

        public string UserId { get; set; }

        public virtual int BoardGameId { get; set; }

        public virtual ICollection<BoardGame> BoardGames { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
