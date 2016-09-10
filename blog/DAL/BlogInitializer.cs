using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.DAL
{
    // The following code causes a database to be created when needed and loads test data into the new database.
    //public class BlogInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseAlways<BlogContext>
    {
        // The Seed method will run when the database is re-created and will re-create the test data
        protected override void Seed(BlogContext context)
        {
            
            // Initialize fans members

            var fans = new List<Fan>
            {
                new Fan {ID = Guid.NewGuid(), FirstName = "Or", LastName = "Levi", Birthday = DateTime.Parse("1993-07-27"), Gender = Gender.Male, Seniority = 4 },
                new Fan {ID = Guid.NewGuid(), FirstName = "Moshe", LastName = "Cohen", Birthday = DateTime.Parse("2003-08-01"), Gender = Gender.Male, Seniority = 3 }
            };

            fans.ForEach(fan => context.Fans.Add(fan));
            context.SaveChanges();


            // Initialize Posts 

            Guid postID1 = Guid.NewGuid();
            Guid postID2 = Guid.NewGuid();

            var posts = new List<Post>
            {
                new Post {ID = postID1, Author = "Brian Matu", AuthorWebsiteUrl = "https://www.google.co.il", Image = "fastandfurious.jpg", Title = "Fast and Furious 1", Date = DateTime.Parse("2001-05-17"), Content = "The Fast and the Furious (also known as Fast & Furious) is an American franchise including a series of action films, which center around illegal street racing and heists, and various other media portraying the characters and situations from the films. Distributed by Universal Pictures, the series was established with the 2001 film titled The Fast and the Furious; followed by six sequels, two short films that tie into the series, and as of May 2015,[1] it has become Universal's biggest franchise of all time." },
                new Post {ID = postID2, Author = "David O'conor", AuthorWebsiteUrl = "https://www.ynet.co.il", Image = "onlythestrongsurvive.jpg", Title = "Only the strong", Date = DateTime.Parse("1993-03-12"), Content = "Only the Strong is a 1993 martial arts film directed by Sheldon Lettich, starring Mark Dacascos. It is considered to be the only Hollywood film that showcases capoeira, an Afro-Brazilian martial art, from beginning to end." }
            };

            posts.ForEach(post => context.Posts.Add(post));
            context.SaveChanges();


            //  Initialize Comments

            var comments = new List<Comment>
            {
                new Comment {CommentID = Guid.NewGuid(), Author = "Barak Obama" , Date = DateTime.Parse("2009-06-15"), Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut." , Title = "Amazing story", PostID = postID1 },
                new Comment {CommentID = Guid.NewGuid(), Author = "Benjamin Netanyahu" , Date = DateTime.Parse("2009-06-15"), Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut." , Title = "Amazing story", PostID = postID1 },
                new Comment {CommentID = Guid.NewGuid(), Author = "Ben Gurion" , Date = DateTime.Parse("2009-06-15"), Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut." , Title = "Amazing story", PostID = postID2 }
            };

            comments.ForEach(comment => context.Comments.Add(comment));
            context.SaveChanges();
        }
    }
}
