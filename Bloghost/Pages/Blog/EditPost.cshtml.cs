using System;
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
    public class EditPostModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        private readonly ILogger<AddPostModel> _logger;
        public EditPostModel(UserManager<User> userManager,
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
            public string Tags { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public Domain.Post CurPost { get; set; }
        public async Task<IActionResult> OnGetAsync(string address, string postUrl)
        {
            try
            {
                CurPost = db.Posts.Where(x => x.Url == postUrl).First();
            }
            catch
            {
                return StatusCode(404);
            }

            Input = new InputModel
            {
                Title = CurPost.Title,
                Content = CurPost.Content,
                Tags = CurPost.TagsStr
            };

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var CurBlog = db.Blogs.Find(CurPost.BlogId);
            if (user.Id != CurBlog.AuthorId)
            {
                return StatusCode(403);
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string address, string postUrl)
        {
            try
            {
                CurPost = db.Posts.Where(x => x.Url == postUrl).First();
            }
            catch
            {
                return StatusCode(404);
            }
            if (ModelState.IsValid)
            {
                var tags = Input.Tags?.Split(';');
                var post = new Domain.Post { BlogId = CurPost.BlogId, Title = Input.Title, Content = Input.Content, Tags = tags, Url = postUrl };
                post.CreateTime = CurPost.CreateTime;
                post.Id = CurPost.Id;
                db.Posts.Remove(CurPost);
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                _logger.LogInformation("User edited post.");
                return RedirectToPage("/Blog/Post", new { blogAddress = address, url = postUrl });
            }
            return Page();
        }
    }
}