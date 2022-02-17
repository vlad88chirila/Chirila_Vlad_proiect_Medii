using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chirila_Vlad_proiect_Medii.Models
{
    public class Producer
    {
        public int ID { get; set; }

        [Display(Name = "Producer Name")]
        public string ProducerName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
