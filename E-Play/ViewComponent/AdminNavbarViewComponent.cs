using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Play.Repository;

namespace E_Play.ViewComponent
{

    [ViewComponent]
    public class AdminNavbarViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}