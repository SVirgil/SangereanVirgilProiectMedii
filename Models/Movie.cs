using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebMedii.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Movie Title")]
        public string Title { get; set; }
        public string Producer { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int StudioID { get; set; }
        public Studio Studio { get; set; } //navigation property
        //public int CategoryID { get; set; }
        //public Category Category { get; set; } //navigation property
        public ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
