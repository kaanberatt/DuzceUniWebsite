using Microsoft.EntityFrameworkCore;
using DuzceUni.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using DuzceUni.Core.Hashing;

namespace DuzceUni.DataAccess.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Admin>? Admins { get; set; }

        public DbSet<Announcement>? Announcements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            const string connectionString = "Server=localhost;Port=3306;Database=DuzceUniWebsite;User=root;password=21085454;Charset=utf8;";
            optionsBuilder.UseLazyLoadingProxies()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .EnableSensitiveDataLogging()
                .ConfigureWarnings(warnings =>
                {
                    warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning);
                });
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			var admin = new Admin()
            {
                AdminId = 1,
                AdminName = "Admin",
                AdminAbout = "Admin",
                AdminMail = "admin@admin.com",
                AdminStatus = true,
            };
            admin.AdminPasswordHash = HashingHelper.HashPassword("Admin123");
            modelBuilder.Entity<Admin>().HasData(admin);
			base.OnModelCreating(modelBuilder);
        }
    }
}  