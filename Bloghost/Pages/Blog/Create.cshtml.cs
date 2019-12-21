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
    public class CreateModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDBContext db;
        private readonly ILogger<CreateModel> _logger;
        public CreateModel(UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor,
            ApplicationDBContext dBContext, ILogger<CreateModel> logger)
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
            [DataType(DataType.Text)]
            [Display(Name = "Address")]
            [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Uncorrect address")]
            [StringLength(32, MinimumLength = 3, ErrorMessage = "The length of the string must be between 3 and 32 characters")]
            public string Address { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var sameAddress = db.Blogs.Where(p => p.Address == Input.Address);
                if (sameAddress.Count() > 0)
                {
                    ModelState.AddModelError(string.Empty, "Sorry, this blog address is not available.");
                    return Page();
                }
                var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                var blog = new Domain.Blog { AuthorId = user.Id, Title = Input.Title, Address = Input.Address };
                db.Blogs.Add(blog);
                await db.SaveChangesAsync();
                _logger.LogInformation("User created a new blog.");
                return RedirectToPage($"/Blog/Index", new { address = blog.Address });
            }
            return Page();
        }
    }
}