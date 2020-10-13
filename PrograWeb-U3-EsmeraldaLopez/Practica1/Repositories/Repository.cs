using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica1.Models;

namespace Practica1.Repositories
{
    public class Repository<T> where T: class
    {
        public sistem14_mapacurricularContext Context { get; set; }


        public Repository(sistem14_mapacurricularContext context)
        {
            Context = context;
        }

        //Patron de repositorios considera 5 métodos

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public T Get(object id)
        {
            return Context.Find<T>(id);
        }

        public void Insert(T entidad)
        {
            Context.Add<T>(entidad);
            Context.SaveChanges();
        }

        public void Delete(T entidad)
        {
            Context.Remove<T>(entidad);
            Context.SaveChanges();
        }

        public void Update(T entidad)
        {
            Context.Update<T>(entidad);
            Context.SaveChanges();

        }
    }
}
