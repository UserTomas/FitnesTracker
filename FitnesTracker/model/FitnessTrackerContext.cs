namespace FitnesTracker.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FitnessTrackerContext : DbContext
    {
        public FitnessTrackerContext() : base("name=FitnessTrackerContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FitnessTrackerContext, Migrations.Configuration>());
        }

        public virtual DbSet<Exercise> Exercise { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<SensorData> SensorData { get; set; }
        public virtual DbSet<Series> Series { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.Series)
                .WithRequired(e => e.Exercise)
                .WillCascadeOnDelete(false);

           modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Exercise)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Ax)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Ay)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Az)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Mx)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.My)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Mz)
                .HasPrecision(28, 0);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.ReceivedAt)
                .HasPrecision(28, 0);

            modelBuilder.Entity<Series>()
                .Property(e => e.Duration)
                .HasPrecision(28, 0);

            modelBuilder.Entity<Series>()
                .Property(e => e.Weight)
                .HasPrecision(28, 0);

            modelBuilder.Entity<Series>()
                .HasMany(e => e.SensorData)
                .WithRequired(e => e.Series)
                .WillCascadeOnDelete(false);
        }
    }
}
