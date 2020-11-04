using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    public class NoodleController : Controller
    {
        // GET: NoodleController
        public List<string> Index()
        {
            return new List<string>() { "拉面", "炒面", "牛肉面"};
        }
    }
}
