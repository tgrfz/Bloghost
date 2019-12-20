using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Bloghost.Domain;
using Microsoft.AspNetCore.Http;
using Bloghost.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bloghost.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public IndexModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dbContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dbContext;
        }
        public Domain.Blog CurBlog { get; set; }
        public List<Domain.Post> Posts { get; set; }
        public IActionResult OnGet(string address)
        {
            try
            {
                CurBlog = db.Blogs.Where(p => p.Address == address).First();
            }
            catch
            {
                return StatusCode(404);
            }

            Posts = db.Posts.Where(x => x.BlogId == CurBlog.Id).OrderByDescending(o => o.CreateTime).ToList();
            return Page();
        }
    }
}