using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloghost.Data;
using Bloghost.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Bloghost.Pages.Home
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public IndexModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor, ApplicationDBContext dbContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dbContext;
        }

        public IQueryable<Domain.Blog> UserBlogs { get; set; }
        public void OnGet()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            UserBlogs = db.Blogs.Where(p => p.AuthorId == userId);
        }
    }
}