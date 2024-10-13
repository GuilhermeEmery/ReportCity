using Microsoft.EntityFrameworkCore;
using Fiap.Api.ReportCity.Models;

namespace Fiap.Api.ReportCity.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {


        public DbSet<CrimePrediction> CrimePredictions { get; set; }
        public DbSet<Surveillance> Surveillances { get; set; }
        public DbSet<AlarmNotification> AlarmNotifications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<IncidentReport> IncidentReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CrimePrediction>().ToTable("CrimePredictions");
            modelBuilder.Entity<Surveillance>().ToTable("Surveillances");
            modelBuilder.Entity<AlarmNotification>().ToTable("AlarmNotifications");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<IncidentReport>().ToTable("IncidentReports");

            modelBuilder.Entity<CrimePrediction>()
                .HasKey(cp => cp.Id);
            modelBuilder.Entity<Surveillance>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<AlarmNotification>()
                .HasKey(an => an.Id);
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);
            modelBuilder.Entity<IncidentReport>()
                .HasKey(ir => ir.Id);


            // Defining relationships
            modelBuilder.Entity<IncidentReport>()
                .HasOne(ir => ir.User)
                .WithMany(u => u.IncidentReports)
                .HasForeignKey(ir => ir.UserId);
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }
    }
}
