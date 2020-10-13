using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using Practica1.Repositories;

namespace Practica1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            //Carreras c = new Carreras()
            //{
            //    Clave = "Y",
            //    Descripcion = "Una carrera de prueba",
            //    Especialidad = "Nombre de la especialidad",
            //    Nombre = "Carrera de prueba",
            //    Plan = "ABC1233"
            //};

            Materias m = new Materias()
            {
                Clave = "ABC123",
                Creditos = 5,
                HorasPracticas = 3,
                HorasTeoricas = 2,
                IdCarrera = 1,
                Nombre = "Materia de prueba",
                Semestre = 1
            };
            sistem14_mapacurricularContext context = new sistem14_mapacurricularContext();

            Repository<Materias> repos = new Repository<Materias>(context);
            repos.Insert(m);

            return Ok("La carrera se agregó");
        }

    }
}
