namespace FitnessTracker.Server.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TrackerContext : DbContext
    {
        public TrackerContext() : base("name=TrackerContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackerContext, FitnessTracker.Server.Migrations.Configuration>());
        }

        public virtual DbSet<Exercise> Exercise { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SensorData> SensorData { get; set; }
        public virtual DbSet<Series> Series { get; set; }


        public bool Login(string name, string password)
        {
            return true;
        }
    }
}