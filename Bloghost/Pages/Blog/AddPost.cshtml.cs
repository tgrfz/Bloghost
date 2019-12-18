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

namespace Bloghost.Pages.Blog
{
    [Authorize]
    public class AddPostModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public AddPostModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dBContext;
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

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Tags")]
            public string Tags { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public Domain.Blog CurBlog { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(string blogAddress)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            var blogs = db.Blogs.Where(p => p.Address == blogAddress);
            if (blogs.Count() == 0)
            {
                return StatusCode(400);
            }
            CurBlog = blogs.First();

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (user.Id != CurBlog.AuthorId)
            {
                return StatusCode(403);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string blogAddress)
        {
            var blogs = db.Blogs.Where(p => p.Address == blogAddress);
            if (blogs.Count() == 0)
            {
                return StatusCode(400);
            }
            CurBlog = blogs.First();

            var tags = Input.Tags.Split(',');
            var post = new Domain.Post { BlogId = CurBlog.Id, Title = Input.Title, Content = Input.Content, Tags = tags };
            db.Posts.Add(post);
            await db.SaveChangesAsync();
            return RedirectToPage($"/Blog/Index", new { address = CurBlog.Address });
        }
    }
}