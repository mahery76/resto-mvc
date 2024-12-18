using RestoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace  RestoMvc.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Users = Set<User>();
        }
        public DbSet<User> Users {get; set;}
    }
}

