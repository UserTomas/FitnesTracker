using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Model
{
    public class Series
    {

        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Duration { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        public virtual Exercise Exercise { get; set; }
        
        public virtual ICollection<SensorData> SensorData { get; set; }
    }
}