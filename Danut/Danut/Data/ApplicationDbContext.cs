using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Danut.Models;

namespace Danut.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Danut.Models.Author> Author { get; set; }
        public DbSet<Danut.Models.Book> Book { get; set; }
        public DbSet<Danut.Models.Library> Library { get; set; }
    }

 
}