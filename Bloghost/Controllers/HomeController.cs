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
using Microsoft.AspNetCore.Http;

namespace Bloghost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor, ApplicationDBContext dbContext)
        {
            _logger = logger;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dbContext;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            IQueryable<Blog> blogs = db.Blogs.Where<Blog>(p => p.AuthorId == userId);
            return View(blogs);
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
