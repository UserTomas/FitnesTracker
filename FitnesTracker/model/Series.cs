namespace FitnesTracker.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Series
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Series()
        {
            SensorData = new HashSet<SensorData>();
        }

        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Duration { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        public virtual Exercise Exercise { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SensorData> SensorData { get; set; }
    }
}
