using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using ZooPlanet.Areas.Admin.Models.ViewModels;
using ZooPlanet.Models;
using ZooPlanet.Repositories;

namespace ZooPlanet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

        animalesContext context;
        public IWebHostEnvironment Enviroment { get; set; }
        public HomeController(animalesContext ctx, IWebHostEnvironment env)
        {
            context = ctx;
            Enviroment = env;
        }


        [Route("Administrador")]
        public IActionResult Index()
        {
            EspeciesRepository repos = new EspeciesRepository(context);

            return View(repos.GetAll());

        }

        [Route("Administrador/Agregar")]
        public IActionResult Agregar()
        {
            AgregarViewModel vm = new AgregarViewModel();
            ClasesRepository repos = new ClasesRepository(context);
            vm.Clases = repos.GetAll();
            return View(vm);
        }

        [Route("Administrador/Agregar")]
        [HttpPost]
        public IActionResult Agregar(AgregarViewModel vm)
        { //Falta validar
            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                repos.Insert(vm.Animalito);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);
                ClasesRepository crepos = new ClasesRepository(context);
                vm.Clases = crepos.GetAll();
                return View(vm);
            }
           
        }


        [Route("Administrador/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            EspeciesRepository repos = new EspeciesRepository(context);
            ClasesRepository clasRepos = new ClasesRepository(context);
            AgregarViewModel vm = new AgregarViewModel();
            vm.Animalito = repos.GetById(id);
            vm.Clases = clasRepos.GetAll();
            if(vm.Animalito==null)
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(vm);
            }
            
        }

        [HttpPost]
        [Route("Administrador/Editar/{id}")]
        public IActionResult Editar(AgregarViewModel vm)
        {
            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                ClasesRepository crepos = new ClasesRepository(context);
                var animalitoBusqueda = repos.GetById(vm.Animalito.Id);
                vm.Clases = crepos.GetAll();
                if (vm.Animalito != null)
                {
                    animalitoBusqueda.IdClase = vm.Animalito.IdClase;
                    animalitoBusqueda.Habitat = vm.Animalito.Habitat;
                    animalitoBusqueda.Especie = vm.Animalito.Especie;
                    animalitoBusqueda.Observaciones = vm.Animalito.Observaciones;
                    animalitoBusqueda.Peso = vm.Animalito.Peso;
                    animalitoBusqueda.Tamaño = vm.Animalito.Tamaño;
                    repos.Update(animalitoBusqueda);
                    return RedirectToAction("Index", "Home");
                }
                else
                    return RedirectToAction("Index", "Home");
                                                 
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);
                ClasesRepository crepos = new ClasesRepository(context);
                vm.Clases = crepos.GetAll();
                return View(vm);
            }                                                            
        }

        [Route("Administrador/Eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            EspeciesRepository repos = new EspeciesRepository(context);
            var animalitoBusqueda = repos.GetById(id);
            if(animalitoBusqueda!=null)
            {
                return View(animalitoBusqueda);
            }
            else
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Route("Administrador/Eliminar/{id}")]
        public IActionResult Eliminar(Especies e)
        {
            EspeciesRepository repos = new EspeciesRepository(context);
            var especie = repos.GetById(e.Id);
            if(especie!=null)
            {
                repos.Delete(especie);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "La especie no existe, o ha sido eliminada con anterioridad");
                return View(e);
            }
            
        }


        [Route("Administrador/Imagen/{id}")]
        public IActionResult Imagen(int id)
        {
            EspeciesRepository repos = new EspeciesRepository(context);
            AgregarViewModel vm = new AgregarViewModel();
            vm.Animalito = repos.GetById(id);
            if(System.IO.File.Exists(Enviroment.WebRootPath+$"/especies/{vm.Animalito.Id}.jpg"))
            {
                vm.Imagen = vm.Animalito.Id + ".jpg";
            }
            else
            {
                vm.Imagen = "nophoto.jpg";
            }
            return View(vm);
        }


         [HttpPost]
        [Route("Administrador/Imagen/{id}")]
        public IActionResult Imagen(AgregarViewModel vm)
        {
            try
            {
                if (vm.Archivo == null)
                {
                    ModelState.AddModelError("", "Debe seleccionar la imagen del producto.");
                    return View(vm);
                }
                else
                {
                    if (vm.Archivo.ContentType != "image/jpeg" || vm.Archivo.Length > 1024 * 1024 * 2)
                    {
                        ModelState.AddModelError("", "Debe seleccionar un archivo jpg de menos de 2MB.");
                        return View(vm);
                    }
                }
                if (vm.Archivo != null)
                {
                    FileStream fs = new FileStream(Enviroment.WebRootPath + "/especies/" + vm.Animalito.Id + ".jpg", FileMode.Create);
                    vm.Archivo.CopyTo(fs);
                    fs.Close();
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);
                return View(vm);
            }
        }
    }
}
