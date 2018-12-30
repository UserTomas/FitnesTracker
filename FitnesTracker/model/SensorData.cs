namespace FitnesTracker.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SensorData")]
    public partial class SensorData
    {
        public int Id { get; set; }

        public int SeriesId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Az { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Mx { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? My { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Mz { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReceivedAt { get; set; }

        public virtual Series Series { get; set; }
    }
}
