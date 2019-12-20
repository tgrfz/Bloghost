using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bloghost.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int BlogId { get; set; }

        public string TagsStr { get; set; }
        [NotMapped]
        public string[] Tags
        {
            get 
            {
                if (TagsStr == null)
                    return new string[] { };
                return TagsStr.Split(';');
            }
            set
            {
                if (value == null)
                    TagsStr = null;
                else
                    TagsStr = string.Join(";", value);
            }
        }
        public Post()
        {
            CreateTime = DateTime.Now;
        }
    }
}
