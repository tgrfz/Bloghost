using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Bloghost.Domain;
using Bloghost.Data;

namespace Bloghost
{
    public class UserBlogsModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        public UserBlogsModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            db = dBContext;
        }

        public IQueryable<Domain.Blog> UserBlogs { get; set; }
        public string Username { get; set; }
        public async Task<IActionResult> OnGetAsync(string username = null)
        {
            User User;
            if (username == null)
            {
                User = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            }
            else
            {
                User = await _userManager.FindByNameAsync(username);
            }
            if (User == null)
                return RedirectToPage("/Home/Index");

            Username = User.UserName;
            UserBlogs = db.Blogs.Where(p => p.AuthorId == User.Id);
            return Page();
        }
    }
}