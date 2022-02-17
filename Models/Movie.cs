using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chirila_Vlad_proiect_Medii.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Movie Title")]
        public string Title { get; set; }
        public string Director { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int ProducerID { get; set; }
        public Producer Producer { get; set; }

        public ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
