using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class Fan
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int Seniority { get; set; } // number of years this fan is a member in the 'Fans Club'
    }

    public enum Gender
    {
        Male,
        Female
    }
}