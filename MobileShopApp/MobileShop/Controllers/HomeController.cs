using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileShop.Entities;
using MobileShop.Models;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPhoneService _phoneService;

        public HomeController(ILogger<HomeController> logger, IPhoneService phoneService)
        {
            _logger = logger;
            _phoneService = phoneService;
        }

        public IActionResult Index()
        {
            var phones = _phoneService.GetPhones();
            var homeViewModel = new HomeViewModel()
            {
                AllPhones = phones
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
