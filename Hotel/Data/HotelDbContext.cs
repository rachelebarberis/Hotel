using Hotel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class HotelDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
       IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>,
       IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }


        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public DbSet<Camera> Camere { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Prenotazione> Prenotazioni { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.ApplicationUserRole)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<ApplicationUserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(u => u.ApplicationUserRole)
                .HasForeignKey(ur => ur.RoleId);

           

        }
    }
}
