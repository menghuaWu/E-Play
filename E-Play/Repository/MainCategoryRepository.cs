using E_Play.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Play.Repository
{
    public class MainCategoryRepository : IMainCategoryRepository
    {
        private readonly ShopDbContext _context;
        public MainCategoryRepository(ShopDbContext context)
        {
            _context = context;
        }
        public override bool AddMainCategory(MainCategory mainCategory)
        {
            _context.MainCategories.Add(mainCategory);
            _context.SaveChanges();
            return true;
        }

        public override void DeleteCategoryById(int id)
        {
            var cid = _context.MainCategories.Single(m=>m.Id == id);
            _context.Entry(cid).Collection(m => m.SubCategories).Load();
            _context.SubCategories.RemoveRange(cid.SubCategories);
            _context.MainCategories.Remove(cid);
            _context.SaveChanges();
        }

        public override void DeleteCategoryByName(string Name)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<MainCategory> GetAll()
        {
            return _context.MainCategories.Include(m=>m.SubCategories).ToList();

        }

        public override MainCategory GetById(int id)
        {
            return _context.MainCategories.Find(id);
        }

        public override MainCategory GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public override bool UpdateCategory(MainCategory mainCategory)
        {
            throw new NotImplementedException();
        }
    }
}
