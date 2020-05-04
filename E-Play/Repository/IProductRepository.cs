using E_Play.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Play.Repository
{
    public abstract class IProductRepository : IRepository<Product>
    {
        public abstract IEnumerable<Product> GetAll();

        public abstract Product GetById(int id);

        public abstract Product GetByName(string Name);
        public abstract IEnumerable<Product> GetBySubCategory(int id);

        public abstract bool AddMainCategory(Product mainCategory);
        public abstract bool UpdateCategory(Product mainCategory);
        public abstract void DeleteCategoryById(int id);
        public abstract void DeleteCategoryByName(string Name);
    }
}
