using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Data;

namespace E_Play.Repository
{
    public abstract class IMainCategoryRepository : IRepository<MainCategory>
    {
        public abstract IEnumerable<MainCategory> GetAll();

        public abstract MainCategory GetById(int id);

        public abstract MainCategory GetByName(string Name);

        public abstract bool AddMainCategory(MainCategory mainCategory);
        public abstract bool UpdateCategory(MainCategory mainCategory);
        public abstract void DeleteCategoryById(int id);
        public abstract void DeleteCategoryByName(string Name);
        
    }
}
