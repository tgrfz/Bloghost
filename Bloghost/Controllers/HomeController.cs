using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bloghost.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Bloghost.Services;
using Bloghost.Data;
using Bloghost.Domain;
using Microsoft.AspNetCore.Identity;

namespace Bloghost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<User> _userManager;
        private ApplicationDBContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context, UserManager<User> userManager)
        {
            _logger = logger;
            db = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
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

        public async Task<IActionResult> SendEmail()
        {
            EmailService emailService = new EmailService(db);
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await emailService.SendEmailAsync(user, "Тема письма", "Тест письма: тест!");
            return RedirectToAction("Index");
        }
    }
}
