using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoQueVN.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChoQueVN.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginPost()
        {
            string _account = Request.Form["Account"];
            string _password = Request.Form["Password"];

            //ma hoa password
            _password = Security.Encrypt(_password.ToString());

            //đăng nhập thành công
            //sét biến session  để kiểm tra các trang trong admin
            HttpContext.Session.SetString("Account", _account);
            return Redirect("/Admin/Home");
        }
    }
}
