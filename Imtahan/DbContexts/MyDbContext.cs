using Imtahan.Models;
using Imtahan.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imtahan.DbContexts
{
    public class MyDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Profession> Professions { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                builder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Name = item.ToString(),
                    NormalizedName = item.ToString().ToUpper()
                });
            }
            base.OnModelCreating(builder);
        }
    }
}
