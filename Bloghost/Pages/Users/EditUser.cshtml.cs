using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Bloghost.Domain;
using Microsoft.AspNetCore.Authorization;

namespace Bloghost.Pages.Users
{
    [Authorize(Roles = "admin")]
    public class EditUserModel : PageModel
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        private User currentUser;
        public EditUserModel(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public class ChangeRoleModel
        {
            public string UserName { get; set; }
            public List<IdentityRole> AllRoles { get; set; }
            public IList<string> UserRoles { get; set; }
            public ChangeRoleModel()
            {
                AllRoles = new List<IdentityRole>();
                UserRoles = new List<string>();
            }
        }
        public ChangeRoleModel ChangeRole { get; set; }
        public async Task<IActionResult> OnGetAsync(string username)
        {
            if (username == "admin")
                return RedirectToPage("/Users/Index");
            User user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var allRoles = _roleManager.Roles.ToList();
                ChangeRole = new ChangeRoleModel
                {
                    UserName = user.UserName,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };
                return Page();
            }
            return RedirectToPage("/Users/Index");
        }

        public async Task<IActionResult> OnPostAsync(string username, List<string> roles)
        {
            currentUser = await _userManager.GetUserAsync(HttpContext.User);
            User user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                await _userManager.AddToRolesAsync(user, new List<string>() { roles[0] });
                return RedirectToPage("/Users/Index");
            }
            return NotFound();
        }
    }
}