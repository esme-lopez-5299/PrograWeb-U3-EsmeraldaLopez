using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U3_Actividad1_Fruteria.Models;
using U3_Actividad1_Fruteria.Models.ViewModels;
using U3_Actividad1_Fruteria.Repositories;

namespace U3_Actividad1_Fruteria.Controllers
{
    public class HomeController : Controller
    {

        [Route("Home/Index")]
        [Route("Home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{id}")]
        public IActionResult Categoria(string id)
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                ProductosRepository repos = new ProductosRepository(context);
                CategoriaViewModel vm = new CategoriaViewModel();
                vm.Nombre = id;
                vm.Productos = repos.GetProductosByCategoria(id).ToList();
                return View(vm);
            }                       
        }

        [Route("detalles/{categoria}/{id}")]
        public IActionResult Ver(string categoria, string id)
        {

            using (fruteriashopContext context = new fruteriashopContext())
            {
                ProductosRepository repos = new ProductosRepository(context);
                Productos p = repos.GetProductoByCategoriaNombre(categoria, id.Replace("-", " "));
                return View(p);
            }            
        }
    }
}
