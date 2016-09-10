using blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace blog.DAL
{
    public class BlogContext : DbContext
    {
        // DB
        public BlogContext() : base("BlogContext")
        {

        }

        // Tables
        public DbSet<Fan> Fans { get; set; }


        // General Settings

        //The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table names from being pluralized
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}