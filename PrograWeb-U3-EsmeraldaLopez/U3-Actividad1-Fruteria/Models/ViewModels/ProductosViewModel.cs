using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U3_Actividad1_Fruteria.Models.ViewModels
{
    public class ProductosViewModel
    {
        public IEnumerable<Categorias> Categorias { get; set; }
        public Productos Producto { get; set; }
        public IFormFile Archivo { get; set; }
        public string Imagen { set; get; }


    }
}
