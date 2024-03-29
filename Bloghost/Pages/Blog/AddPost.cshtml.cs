﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Bloghost.Domain;
using Bloghost.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Bloghost.Pages.Blog
{
    [Authorize]
    public class AddPostModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        private readonly ILogger<AddPostModel> _logger;
        public AddPostModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext,
            ILogger<AddPostModel> logger)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dBContext;
            _logger = logger;
        }
        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Title")]
            public string Title { get; set; }

            [Required]
            [DataType(DataType.MultilineText)]
            [Display(Name = "Content")]
            public string Content { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Tags")]
            [RegularExpression(@"^[a-zA-Z0-9_;]+$", ErrorMessage = "Uncorrect tag")]
            [StringLength(20, MinimumLength = 2, ErrorMessage = "The length of the string must be between 2 and 20 characters")]
            public string Tags { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public Domain.Blog CurBlog { get; set; }
        public async Task<IActionResult> OnGetAsync(string blogAddress)
        {
            try
            {
                CurBlog = db.Blogs.Where(p => p.Address == blogAddress).First();
            }
            catch
            {
                return StatusCode(404);
            }

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (user.Id != CurBlog.AuthorId)
            {
                return StatusCode(403);
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string blogAddress)
        {
            try
            {
                CurBlog = db.Blogs.Where(p => p.Address == blogAddress).First();
            }
            catch
            {
                return StatusCode(404);
            }
            if (ModelState.IsValid)
            {
                var tags = Input.Tags?.Split(';');
                var url = string.Join("-", new string[] { DateTime.Now.ToString("yyyy-MM-dd"), Input.Title.GetHashCode().ToString() });
                //TODO: check if this url already exists
                var post = new Domain.Post { BlogId = CurBlog.Id, Title = Input.Title, Content = Input.Content, Tags = tags, Url = url };
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                _logger.LogInformation("User created a new post.");
                return RedirectToPage($"/Blog/Index", new { address = CurBlog.Address });
            }
            return Page();
        }
    }
}