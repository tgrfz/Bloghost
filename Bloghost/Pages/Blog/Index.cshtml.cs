using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloghost.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bloghost.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private ApplicationDBContext db;
        public IndexModel(ApplicationDBContext dbContext)
        {
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
        public async Task<IActionResult> OnPostDeleteBlogAsync(string address)
        {
            try
            {
                CurBlog = db.Blogs.Where(p => p.Address == address).First();
            }
            catch
            {
                return StatusCode(404);
            }
            var posts = db.Posts.Where(x => x.BlogId == CurBlog.Id).ToList();
            foreach (var post in posts)
            {
                var comments = db.Comments.Where(x => x.PostId == post.Id).ToList();
                foreach (var comm in comments)
                {
                    db.Comments.Remove(comm);
                }
                db.Posts.Remove(post);
            }
            db.Blogs.Remove(CurBlog);
            await db.SaveChangesAsync();
            return RedirectToPage("/Home/Index");
        }
    }
}