using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Bloghost.Models;
using Bloghost.Domain;
using Microsoft.AspNetCore.Http;
using Bloghost.Data;

namespace Bloghost.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public BlogController(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dbContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dbContext;
        }

        [Route("Blog/{address}")]
        public async Task<IActionResult> Index(string address)
        {
            var tmp = db.Blogs.Where<Blog>(p => p.Address == address);
            return View(tmp.First());
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateBlog(string title, string address)
        {
            var sameAddress = db.Blogs.Where<Blog>(p => p.Address == address);
            if (sameAddress.Count() > 0)
            {
                ModelState.AddModelError(string.Empty, "Sorry, this blog address is not available.");
                return View();
            }
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var blog = new Blog { AuthorId = user.Id, Title = title, Address = address };
            db.Blogs.Add(blog);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}