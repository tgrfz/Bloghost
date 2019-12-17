using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Bloghost.Domain;
using Microsoft.AspNetCore.Http;
using Bloghost.Data;
using Microsoft.AspNetCore.Authorization;

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
        public void OnGet(string address)
        {
            var tmp = db.Blogs.Where(p => p.Address == address);
            CurBlog = tmp.First();
        }
    }
}