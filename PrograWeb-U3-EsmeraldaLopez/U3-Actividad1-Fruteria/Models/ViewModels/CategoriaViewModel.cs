using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U3_Actividad1_Fruteria.Models.ViewModels
{
    public class CategoriaViewModel
    {
        public string Nombre { get; set; }
        public IEnumerable<Models.Productos> Productos { get; set; }
    }
}
