using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketTrackerModels;

namespace TicketTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // Purposely empty; sets options appropriately
        }
        public ApplicationDbContext(): base()
        {
            // Purposely empty; necessary for scaffolding
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(x =>
            {
                x.HasData(
                    new Category() { Id = 1, Name = "Credentials", Description = "Usernames, passwords, logins, roles, etc", IsActive = true },
                    new Category() { Id = 2, Name = "Network", Description = "IP addresses and VPN, Cable, etc", IsActive = true },
                    new Category() { Id = 3, Name = "Usability", Description = "Web pages, buttons, links", IsActive = true }
                );
            });
        }
    }
}