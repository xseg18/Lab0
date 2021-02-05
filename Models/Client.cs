using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab0.Models
{
    public class Client
    {
        [Display(Name = "Nombre")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Apellido")]
        public string LName { get; set; }
        [Required]
        [Display(Name = "Número telefónico")]
        public int? Phone { get; set; }
        [Required]
        [Display(Name = "Descripción del cliente")]
        public string Description { get; set; }
    }
}
