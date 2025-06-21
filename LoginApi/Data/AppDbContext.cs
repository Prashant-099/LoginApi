using Microsoft.EntityFrameworkCore;
using LoginApi.Models;
using System.Collections.Generic;

namespace LoginApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
