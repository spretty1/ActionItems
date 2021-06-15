using FrontEndActionItem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndActionItem.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string number)
        {
            int n1 = 0, n2 = 1, n3, i;
            int n = Convert.ToInt32(number);
            string Series = "";

            Series = n1 + ", " + n2;

            for (i = 2; i < n; i ++)
            {
                n3 = n1 + n2;
                Series = Series + ", " + n3;
                n1 = n2;
                n2 = n3;
            }
            
            ViewBag.Message = Series; 

            return View();
        }

    }
}