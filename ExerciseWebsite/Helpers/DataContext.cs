using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ExerciseWebsite.Entities;

namespace ExerciseWebsite.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<SetList> SetLists { get; set; }
        public DbSet<Workout> Workouts { get; set; }

    }
}
