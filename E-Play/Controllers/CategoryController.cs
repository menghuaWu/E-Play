using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Data;
using E_Play.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_Play.Controllers
{
    public class CategoryController : Controller
    {
        private IMainCategoryRepository _mainCategory;
        private ISubCategoryRepository _subCategory;
        private IProductRepository _product;
        
        public CategoryController(IMainCategoryRepository mainCategory, ISubCategoryRepository subCategory ,IProductRepository product)
        {
            _mainCategory = mainCategory;
            _subCategory = subCategory;
            _product = product;
        }
        public IActionResult Index()
        {
            return View(_mainCategory.GetAll());
            //return Json(_mainCategory.GetAll());
        }

        public IActionResult GetBySubCategory(int id)
        {
            //return Json(_product.GetBySubCategory(id));
            return Json("test");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MainCategory mainCategory)
        {
            _mainCategory.AddMainCategory(mainCategory);
            return RedirectToAction("Index");
        }
        
        public IActionResult Details(int id)
        {
            ViewBag.MainId = id;
            return View(_subCategory.GetByMainId(id));
        }

        public IActionResult Delete(int id)
        {
            _mainCategory.DeleteCategoryById(id);
            return RedirectToAction("Index");
        }
    }
}