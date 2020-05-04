using E_Play.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Play.Repository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ShopDbContext _context;
        public SubCategoryRepository(ShopDbContext context)
        {
            _context = context;
        }
        public override bool AddSubCategory(SubCategory subCategory)
        {
            SubCategory sub = new SubCategory()
            {
                Name = subCategory.Name,
                MainCategoryId = subCategory.MainCategoryId
            };
            _context.SubCategories.Add(sub);
            _context.SaveChanges();
            return true;
        }

        public override void DeleteSubCategoryById(int id)
        {
            var tmp = _context.SubCategories.Find(id);
            _context.SubCategories.Remove(tmp);
            _context.SaveChanges();
            
        }

        public override void DeleteSubCategoryByName(string name)
        {
            var tmp = _context.SubCategories.Where(m => m.Name == name).FirstOrDefault();
            _context.SubCategories.Remove(tmp);
            _context.SaveChanges();
        }

        public override IEnumerable<SubCategory> GetAll()
        {
            return _context.SubCategories.ToList();
        }

        public override SubCategory GetById(int id)
        {
            return _context.SubCategories.Find(id);
        }

        public override IEnumerable<SubCategory> GetByMainId(int id)
        {
            return _context.SubCategories.Where(m => m.MainCategoryId == id).ToList();
        }

        public override SubCategory GetByName(string Name)
        {
            return _context.SubCategories.Where(m => m.Name == Name).FirstOrDefault();
        }

        public override bool UpdateSubCategory(SubCategory subCategory)
        {
            var sub = _context.SubCategories.Find(subCategory.Id);
            sub.Name = subCategory.Name;
            sub.MainCategoryId = subCategory.MainCategoryId;
            _context.SaveChanges();
            return true;
        }
    }
}
