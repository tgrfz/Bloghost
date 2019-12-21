using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Bloghost.Domain;
using Microsoft.AspNetCore.Authorization;

namespace Bloghost.Pages.Users
{
    [Authorize(Roles = "admin,moderator")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        public IndexModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<User> UserList { get; set; }
        public void OnGet()
        {
            UserList = _userManager.Users.ToList();
        }
    }
}