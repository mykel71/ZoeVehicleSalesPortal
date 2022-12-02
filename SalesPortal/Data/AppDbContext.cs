using Microsoft.EntityFrameworkCore;
using SalesPortal.Models;

namespace SalesPortal.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model_Car>().HasKey(am => new
            {
                am.ModelId,
                am.CarId
            });

            modelBuilder.Entity<Model_Car>().HasOne(m => m.Car).WithMany(am => am.Models_Cars).HasForeignKey(m => m.CarId);
            modelBuilder.Entity<Model_Car>().HasOne(m => m.Model).WithMany(am => am.Models_Cars).HasForeignKey(m => m.ModelId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model_Car> Models_Cars { get; set; }
        public DbSet<Make> Makes { get; set; }


       
    }
}
}
