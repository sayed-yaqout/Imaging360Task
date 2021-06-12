using System;
using System.Collections.Generic;

namespace Imaging360Task.models
{
    public class Post
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } 
    }
}
