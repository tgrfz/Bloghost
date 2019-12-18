using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bloghost.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public int BlogId { get; set; }

        public string _tags;
        [NotMapped]
        public string[] Tags
        {
            get { return _tags.Split(';'); }
            set
            {
                _tags = string.Join(";", value);
            }
        }
        public Post()
        {
            CreateTime = DateTime.Now;
        }
    }
}
