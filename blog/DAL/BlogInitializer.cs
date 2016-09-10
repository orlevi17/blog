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
            var fans = new List<Fan>
            {
                new Fan {ID = Guid.NewGuid(), FirstName = "Or", LastName = "Levi", Birthday = DateTime.Parse("1993-07-27"), Gender = Gender.Male, Seniority = 4 },
                new Fan {ID = Guid.NewGuid(), FirstName = "Moshe", LastName = "Cohen", Birthday = DateTime.Parse("2003-08-01"), Gender = Gender.Male, Seniority = 3 }
            };

            fans.ForEach(fan => context.Fans.Add(fan));
            context.SaveChanges();
        }
    }
}
