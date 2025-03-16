using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S1L05_RWD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Schedule()
        {

            return View();
        }

        public ActionResult Consultation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Consultation(string FirstName, string LastName, string Email, string Date, string Message)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email))
            {
                ViewBag.Error = "Please fill in all required fields.";
                return View();
            }
            ViewBag.Success = "Consultation request submitted!";
            return View();
        }

        
       
    }
}