using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Server.Model
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? DateCreated { get; set; }  
        
        public virtual ICollection<Exercise> Exercise { get; set; }

        public override string ToString()
        {
            return "PersonID:" + Id + ", Name:" + FirstName + " " + LastName + "Created: " + DateCreated.ToString();
        }
    }
}