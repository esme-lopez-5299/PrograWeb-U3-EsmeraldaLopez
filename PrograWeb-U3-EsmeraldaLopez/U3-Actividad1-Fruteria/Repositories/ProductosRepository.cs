using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using U3_Actividad1_Fruteria.Models;

namespace U3_Actividad1_Fruteria.Repositories
{
    public class ProductosRepository: Repository<Productos>
    {
        public ProductosRepository(fruteriashopContext context) : base(context) { }
        
            public IEnumerable<Productos> GetProductosByCategoria(string nombre)
            {
            return Context.Productos.Where(x => x.IdCategoriaNavigation.Nombre == nombre);
            }

        public IEnumerable<Productos> GetProductosByCategoria(int? idCategoria)
        {
            return Context.Productos.Include(x=>x.IdCategoriaNavigation).Where(x => idCategoria==null|| x.IdCategoria == idCategoria).OrderBy(x=>x.Nombre);

        }

        public Productos GetProductoByCategoriaNombre(string categoria, string nombre)
        {
            return Context.Productos.Include(x=>x.IdCategoriaNavigation).FirstOrDefault(x => x.IdCategoriaNavigation.Nombre == categoria&&x.Nombre==nombre);

        }

    }
}
