using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U3_Actividad1_Fruteria.Models;


namespace U3_Actividad1_Fruteria.Services
{
    public class CategoriasService
    {
        public List<Categorias> Categorias { get; set; }

        public CategoriasService()
        {

            using (fruteriashopContext context = new fruteriashopContext())
            {
                Repositories.Repository<Categorias> repos = new Repositories.Repository<Categorias>(context);
                Categorias = repos.GetAll().Where(x => x.Eliminado == false).OrderBy(x => x.Nombre).ToList();
            }
            
        }
    }
}
