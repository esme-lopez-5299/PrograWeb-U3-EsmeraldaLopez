using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using U3_Actividad1_Fruteria.Models;
using U3_Actividad1_Fruteria.Models.ViewModels;
using U3_Actividad1_Fruteria.Repositories;

namespace U3_Actividad1_Fruteria.Controllers
{
    public class ProductosCotroller : Controller
    {
        [Route("Productos")]
        
        public IActionResult Index()
        {
            ProductosIndexViewModel vm = new ProductosIndexViewModel();

            fruteriashopContext context = new fruteriashopContext();
            CategoriasRepository categoriasRepository = new CategoriasRepository(context);
            ProductosRepository productosRepository = new ProductosRepository(context);

            int? id = null;
            vm.Categorias = categoriasRepository.GetAll();
            vm.Productos = productosRepository.GetProductosByCategoria(id);
            return View(vm);
        }

        [Route("Productos")]
        
        [HttpPost]
        public IActionResult Index(ProductosIndexViewModel vm)
        {
            fruteriashopContext context = new fruteriashopContext();
            CategoriasRepository categoriasRepository = new CategoriasRepository(context);
            ProductosRepository productosRepository = new ProductosRepository(context);

            vm.Categorias = categoriasRepository.GetAll();
            vm.Productos = productosRepository.GetProductosByCategoria(vm.IdCategoria);
            return View(vm);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Eliminar()
        {
            return View();
        }
    }
}
