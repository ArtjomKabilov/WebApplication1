using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<appointment_with_the_hairdresser2.Tootaja> Tootaja { get; set; }

        public DbSet<appointment_with_the_hairdresser2.Teenus> Teenus { get; set; }

        public DbSet<appointment_with_the_hairdresser2.Kasutaja> Kasutaja { get; set; }

        public DbSet<appointment_with_the_hairdresser2.Tellimus> Tellimus { get; set; }

    }
}