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
using Microsoft.Extensions.Logging;

namespace Bloghost.Pages.Users
{
    [Authorize(Roles = "admin")]
    public class EditUserModel : PageModel
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        private readonly ILogger<EditUserModel> _logger;
        public EditUserModel(RoleManager<IdentityRole> roleManager, 
            UserManager<User> userManager, 
            ILogger<EditUserModel> logger)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _logger = logger;
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
            User user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                _logger.LogInformation("User {0} removed from role {1}", user.UserName, userRoles[0]);
                await _userManager.AddToRolesAsync(user, new List<string>() { roles[0] });
                _logger.LogInformation("User {0} added to role {1}", user.UserName, roles[0]);
                return RedirectToPage("/Users/Index");
            }
            return NotFound();
        }
    }
}