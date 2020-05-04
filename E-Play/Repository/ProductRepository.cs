using E_Play.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E_Play.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _context;
        public ProductRepository(ShopDbContext context)
        {
            _context = context;
        }
        public override bool AddMainCategory(Product mainCategory)
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

        public override IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public override Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public override Product GetByName(string Name)
        {
            return _context.Products.Where(m => m.Name == Name).FirstOrDefault();
        }

        public override IEnumerable<Product> GetBySubCategory(int id)
        {
            return _context.Products.Where(m => m.SubCategoryId == id).ToList();
        }

        public override bool UpdateCategory(Product mainCategory)
        {
            throw new NotImplementedException();
        }
    }
}
