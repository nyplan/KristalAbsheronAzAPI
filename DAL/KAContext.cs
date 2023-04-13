using KristalAbsheronAzAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace KristalAbsheronAzAPI.DAL
{
    public class KAContext : DbContext
    {
        public KAContext(DbContextOptions<KAContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompletedProject>()
                .HasDiscriminator<string>("ProjectType")
                .HasValue<CompletedProject>("CompletedProject")
                .HasValue<OngoingProject>("OngoingProject");
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsPhoto> NewsPhotos { get; set; }
        public DbSet<ProjectPhoto> ProjectPhotos { get; set; }
        public DbSet<PlanOfApartment> PlanOfApartments { get; set; }
        public DbSet<CompletedProject> CompletedProjects { get; set; }

    }
}
