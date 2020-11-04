using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        // GET: UserController1
        public List<string> Index()
        {
            return new List<string>() { "Alex", "hAlex"};
        }
    }
}
