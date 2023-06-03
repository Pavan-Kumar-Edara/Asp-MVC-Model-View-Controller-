using Microsoft.AspNetCore.Mvc;
using MVCFoodDelivery.Models;
using System.Xml.Linq;

namespace MVCFoodDelivery.Controllers
{
    public class FoodController : Controller
    {
        //[ViewData]
        //public string Title { get; set; }
        public IActionResult Index()
        {


            var toLogin = new List<ToLogin>
            {
                new ToLogin {Email="pavan@gmail.com",Password="12345678"},
                new ToLogin {Email="rohit@gmail.com",Password="87654321"},
            };
            //ViewData["toLogin"]= toLogin;
            ViewData["title"] = "Login Details";
            //Title = "Login Info";

            //ViewBag.ToLogin = toLogin;

            var newLogin = new ToLogin
            {
                Email = "shivu@gmail.com",
                Password = "123789"
            };

            TempData["Email"] = "david@gmail.com";

            return View(newLogin);
        }
        public IActionResult Login()
        {
            string email;
            if (TempData.ContainsKey("Email"))
                email = TempData["Email"].ToString();
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
    }
}
