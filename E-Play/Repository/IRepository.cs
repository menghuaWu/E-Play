using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Data;

namespace E_Play.Repository
{
    public interface IRepository<T>
    {
        public abstract IEnumerable<T> GetAll();
        public abstract T GetById(int id);
        public abstract T GetByName(string Name);
    }
}
