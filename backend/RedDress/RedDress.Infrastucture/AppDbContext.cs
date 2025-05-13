using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedDress.Core.Entities;
using System.Reflection;

namespace RedDress.Infrastucture
{
    public class AppDbContext : IdentityDbContext<UserAccount> // Now UserAccount inherits from IdentityUser
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply all configurations from the current assembly (which will apply your custom configuration classes)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Optional: Ignore unwanted Identity entities
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();

            modelBuilder.Entity<UserAccount>()
                .ToTable("UserAccounts");
        }

        // Define your DbSets for your entities
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<ClothesType> ClothesTypes { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

        public DbSet<ClothesColor> ClothesColors { get; set; }

        public DbSet<ClothesVariant> ClothesVariants { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Cart> carts { get; set; }

    }
}
