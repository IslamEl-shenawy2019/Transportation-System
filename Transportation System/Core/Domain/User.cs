using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        TimeSpan age;
        public TimeSpan Age {
            get
            {
                return age;
            }
            set {
                age = DateTime.Now - BirthDate;
            } }
    }
}
