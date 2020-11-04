using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.controllers
{
    public class Test:Controller
    {
        public ActionResult Index()
        {
            return Content("hello from test home");
        }
        //[Route("[action]")]
        public string About()
        {
            return "hello test about";
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
