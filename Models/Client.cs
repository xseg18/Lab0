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

        public void SortN (List<Client> CL)
        {
            Client aux = new Client();
            for (int i = 0; i < CL.Count() - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (CL[j].Name[0] > CL[j + 1].Name[0])
                    {
                        aux = CL[j];
                        CL[j] = CL[j + 1];
                        CL[j + 1] = aux;
                    }
                }
            }
        }

        public void SortL(List<Client> CL)
        {
            Client aux = new Client();
            for (int i = 0; i < CL.Count() - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (CL[j].LName[0] > CL[j + 1].LName[0])
                    {
                        aux = CL[j];
                        CL[j] = CL[j + 1];
                        CL[j + 1] = aux;
                    }
                }
            }
        }
    }
}
