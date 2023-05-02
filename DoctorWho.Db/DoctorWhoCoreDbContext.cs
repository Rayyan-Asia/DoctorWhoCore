using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }  
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Episode> Episodes { get; set; }    
        public DbSet<Author> Authors { get; set; }
        public DbSet<EnemyEpisode> EnemyEpisodes { get; set; }

        public DbSet<CompanionEpisode> CompanionEpisodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\localDb; Initial Catalog = DoctorWhoCore");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            var modelManager = new ModelManager(modelBuilder);
            modelManager.SetShadowProperties();
            modelManager.SetupManytoManyRelationships();
            modelManager.SeedData();
            
        }
        
    }
}