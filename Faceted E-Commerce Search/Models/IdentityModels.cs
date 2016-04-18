using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Faceted_E_Commerce_Search.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ColorModel>().HasKey<int>(l => l.ColorId);
            modelBuilder.Entity<PhoneInfoModel>().HasKey<int>(l => l.PhoneId);
            modelBuilder.Entity<MakerModel>().HasKey<int>(l => l.MakerId);
            modelBuilder.Entity<OSModel>().HasKey<int>(l => l.OSId);
            modelBuilder.Entity<PicturesLink>().HasKey<int>(l => l.PictureId);
        }
        public DbSet<MakerModel> MakerModels { get; set; }
        public DbSet<PhoneInfoModel> PhoneModels { get; set; }
        public DbSet<ColorModel> Colors { get; set; }
        public DbSet<OSModel> OperationSystems { get; set; }
        public DbSet<PicturesLink> Pictures { get; set; }
    }
}