using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chirila_Vlad_proiect_Medii.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
