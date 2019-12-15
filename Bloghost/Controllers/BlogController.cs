using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Bloghost.Models;

namespace Bloghost.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Create(string name)
        {
            return View(new CreateBlogModel { UserName = name});
        }

        public async Task<IActionResult> OnPostAsync()
        {

        }
    }
}