using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bloghost.Models
{
    public class CreateBlogModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
