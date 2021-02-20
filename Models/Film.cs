using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SangereanVirgilProiectMedii.Models
{
    public class Film
    {
        public int ID { get; set; }

        [Display(Name = "Titlul filmului")]
        public string Titlu { get; set; }
        public string Gen { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal PretBilet { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLansarii { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

    }
}
