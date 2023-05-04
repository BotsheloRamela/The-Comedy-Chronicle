using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using The_Comedy_Chronicle.Models;

namespace The_Comedy_Chronicle.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<The_Comedy_Chronicle.Models.Joke>? Joke { get; set; }
    }
}