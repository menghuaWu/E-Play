using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Play.Repository;

namespace E_Play.ViewComponent
{

    [ViewComponent]
    public class NavbarViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private IMainCategoryRepository _mainCategory;
        public NavbarViewComponent(IMainCategoryRepository mainCategory)
        {
            _mainCategory = mainCategory;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mainCategory.GetAll());
        }
    }
}