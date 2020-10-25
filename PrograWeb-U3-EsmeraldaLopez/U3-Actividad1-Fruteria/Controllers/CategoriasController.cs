using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using U3_Actividad1_Fruteria.Models;
using U3_Actividad1_Fruteria.Repositories;

namespace U3_Actividad1_Fruteria.Controllers
{
    public class CategoriasController : Controller
    {
        [Route("Categorias")]
        public IActionResult Index()
        {
            fruteriashopContext context = new fruteriashopContext();
            Repositories.Repository<Categorias> repos = new Repositories.Repository<Categorias>(context);
            return View(repos.GetAll().Where(x=>x.Eliminado==false).OrderBy(x=>x.Nombre));
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Agregar(Categorias c)
        {
            try
            {
                fruteriashopContext context = new fruteriashopContext();
                CategoriasRepository repos = new CategoriasRepository(context);
                repos.Insert(c);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(c);
                
            }
            
        }

        public IActionResult Editar(int id)
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                CategoriasRepository repos = new CategoriasRepository(context);
                var categoria = repos.Get(id);
                if(categoria==null)
                {
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
                
        }
        
        [HttpPost]
        public IActionResult Editar(Categorias vm)
        {
            try
            {
                using (fruteriashopContext context = new fruteriashopContext())
                {
                    CategoriasRepository repos = new CategoriasRepository(context);
                    var original = repos.Get(vm.Id);
                    original.Nombre = vm.Nombre;
                    if (original != null)
                    {
                        repos.Update(original);
                    }
                    
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(vm);                
            }


        }

        public IActionResult Eliminar(int id)
        {
            using(fruteriashopContext context=new fruteriashopContext())
            {
                CategoriasRepository repos = new CategoriasRepository(context);
                var categoria = repos.Get(id);
                if (categoria == null)
                    return RedirectToAction("Index");
                else
                    return View(categoria);
            }
            
        }

        [HttpPost]
        public IActionResult Eliminar(Categorias c)
        {
            //Dos tipos de eliminación
            //Fisica: Borro un registro de la bd: Operacion DELETE
            //Logica: Marco el registro como eliminado: Operación UPDATE
            //try
            //{

            ////FISICA
            //using (fruteriashopContext context = new fruteriashopContext())
            //{
            //    CategoriasRepository repos = new CategoriasRepository(context);
            //    var categoria = repos.Get(c.Id);
            //    repos.Delete(categoria);

            //    return RedirectToAction("Index");

            //}
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("", ex.Message);
            //    return View(c);
            //}


            //Logica
            try
            {
                using (fruteriashopContext context = new fruteriashopContext())
                {
                    CategoriasRepository repos = new CategoriasRepository(context);
                    var categoria = repos.Get(c.Id);
                    categoria.Eliminado = true;
                    repos.Update(categoria);
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(c);
            }

        }
    }
}
