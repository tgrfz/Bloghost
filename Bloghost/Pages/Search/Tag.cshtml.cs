using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bloghost.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bloghost.Pages.Search
{
    public class TagModel : PageModel
    {
        private ApplicationDBContext db;
        public TagModel(ApplicationDBContext dbContext)
        {
            db = dbContext;
        }
        public string Tag { get; set; }
        public List<Domain.Post> Posts { get; set; }
        public void OnGet(string tag)
        {
            Tag = tag;
            try
            {
                Posts = db.Posts.Where(x => x.TagsStr.Contains(tag)).OrderByDescending(x => x.CreateTime).ToList();
            }
            catch
            {
                Posts = new List<Domain.Post>();
            }
        }
    }
}