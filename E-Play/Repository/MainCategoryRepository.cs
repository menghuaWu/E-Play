using E_Play.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public override void DeleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCategoryByName(string Name)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<MainCategory> GetAll()
        {
            return _context.MainCategories.ToList();

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
