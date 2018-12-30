using System;
using System.Collections.Generic;

namespace FitnessTracker.Server.Model
{
    public class Exercise
    {
        public int Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public int PersonId { get; set; }
            
        public virtual User User { get; set; }
        
        public virtual ICollection<Series> Series { get; set; }
    }
}