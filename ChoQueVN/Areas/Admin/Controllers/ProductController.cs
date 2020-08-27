using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChoQueVN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Category
        public IActionResult ProductCategory()
        {
            return View();
        }
        #endregion

        #region News
        public IActionResult Product()
        {
            return View();
        }
        #endregion

        public IActionResult Add()
        {
            var name = Request.Form[""].ToString();
            return Redirect("/Admin/Home");
        }
    }
}
