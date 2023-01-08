using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Project.Areas.Identity.Data;

namespace Project.Data
{
    public class ProjectContext : IdentityDbContext<CustomUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Computer>().ToTable("Computer");
        }
    }
}
