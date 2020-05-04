using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Data;

namespace E_Play.Repository
{
    public abstract class ISubCategoryRepository : IRepository<SubCategory>
    {
        public abstract IEnumerable<SubCategory> GetAll();

        public abstract SubCategory GetById(int id);


        public abstract SubCategory GetByName(string Name);
        public abstract IEnumerable<SubCategory> GetByMainId(int id);

        public abstract bool AddSubCategory(SubCategory subCategory);
        public abstract bool UpdateSubCategory(SubCategory subCategory);
        public abstract void DeleteSubCategoryById(int id);
        public abstract void DeleteSubCategoryByName(string name);
    }
}
