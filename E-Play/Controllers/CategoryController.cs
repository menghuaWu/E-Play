using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Play.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_Play.Controllers
{
    public class CategoryController : Controller
    {
        private IMainCategoryRepository _mainCategory;
        public CategoryController(IMainCategoryRepository mainCategory)
        {
            _mainCategory = mainCategory;
        }
        public IActionResult Index()
        {
            
            return Json(_mainCategory.GetAll());
        }
    }
}