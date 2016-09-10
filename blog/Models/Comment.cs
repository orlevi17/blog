using System;

namespace blog.Models
{
    public class Comment
    {
        public Guid CommentID { get; set; }
        public Guid PostID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AuthorWebsiteUrl { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// The PostID property is a foreign key, and the corresponding navigation property is Post.An Comment entity is associated with one Post
        /// entity, so the property can only hold a single Post entity(unlike the Post.Comments navigation property, which can hold multiple 
        /// Comment entities).
        /// </summary>
        public virtual Post Post { get; set; }
    }
}