using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class Post
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AuthorWebsiteUrl { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }

        /// <summary>
        /// The Comments property is a navigation property. Navigation properties hold other entities that are related to this entity. 
        /// In this case, the Comments property of a Post entity will hold all of the Comment entities that are related to that Post entity. 
        /// In other words, if a given Post row in the database has two related Comment rows (rows that contain that post's primary key value
        /// in theirPostID foreign key column), that Post entity's Comments navigation property will contain those two Comment entities.
        /// Navigation properties are typically defined as virtual so that they can take advantage of certain Entity Framework functionality such 
        /// as lazy loading.
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
