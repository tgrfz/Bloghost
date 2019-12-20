using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Bloghost.Domain;
using Bloghost.Data;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bloghost.Pages.Blog
{
    public class PostModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public PostModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dBContext;
        }

        public Post Post { get; set; }
        public Domain.Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            public string CommentContent { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet(string blogAddress, string url)
        {
            try
            {
                Post = db.Posts.Where(x => x.Url == url).First();
                Blog = db.Blogs.Find(Post.BlogId);
            }
            catch
            {
                return StatusCode(404);
            }
            Comments = db.Comments.Where(x => x.PostId == Post.Id).OrderBy(x => x.CreateTime).ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string blogAddress, string url)
        {
            try
            {
                Post = db.Posts.Where(x => x.Url == url).First();
            }
            catch
            {
                return StatusCode(404);
            }
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                var comm = new Comment { AuthorId = user.Id, Content = Input.CommentContent, PostId = Post.Id };
                db.Comments.Add(comm);
                await db.SaveChangesAsync();
                return RedirectToAction("OnGet");
            }
            return Page();
        }
    }
}