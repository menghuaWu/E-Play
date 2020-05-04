using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Data;
using E_Play.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_Play.Controllers
{
    public class SubCategoryController : Controller
    {
        private ISubCategoryRepository _subCategory;
        public SubCategoryController(ISubCategoryRepository subCategory)
        {
            _subCategory = subCategory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateSub(int id)
        {

            ViewBag.MainCategory = id;
            return View();
        }

        [HttpPost]
        public IActionResult CreateSub(SubCategory subCategory)
        {
            var result = _subCategory.AddSubCategory(subCategory);
            return RedirectToAction("Details", "Category", new { id = subCategory.MainCategoryId });
        }

        public IActionResult Delete(int id)
        {
            var tmp = _subCategory.GetById(id);
            var idx = tmp.MainCategoryId;
            _subCategory.DeleteSubCategoryById(id);
            return RedirectToAction("Details", "Category", new { id = idx });
        }

        public IActionResult Edit(int id)
        {
            var tmp = _subCategory.GetById(id);
            return View(tmp);
        }

        [HttpPost]
        public IActionResult Edit(SubCategory subCategory)
        {
            _subCategory.UpdateSubCategory(subCategory);
            return RedirectToAction("Details", "Category", new { id = subCategory.MainCategoryId });
        }
    }
}