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

        /// <summary>
        /// The Gender property is an enum. The question mark after the Gender type declaration indicates that the Gender property is nullable.
       ///  A gender that's null is different from a empty string gender — null means a gender isn't known or hasn't been assigned yet.
        /// </summary>
        public Gender? Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int Seniority { get; set; } // number of years this fan is a member in the 'Fans Club'
    }

    public enum Gender
    {
        Male,
        Female
    }
}