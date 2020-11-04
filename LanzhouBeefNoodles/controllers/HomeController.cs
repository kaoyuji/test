using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using LanzhouBeefNoodles.ViewModels;

namespace LanzhouBeefNoodles.controllers
{
    //[Route("Home")]
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedbackRepository _feedbackRepository;
        public HomeController(INoodleRepository noodlRepository, IFeedbackRepository feedbackRepository) 
        {
            _noodleRepository = noodlRepository;
            _feedbackRepository = feedbackRepository;
        }
        // GET: HomeController
        //[Route("Index")]
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            var viewModle = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()
            };
            return View(viewModle);
        }
        //[Route("[action]")]
        public string About()
        {
            return "hello about";
        }
        public IActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
