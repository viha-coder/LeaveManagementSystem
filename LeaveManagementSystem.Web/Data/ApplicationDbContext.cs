using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                {
                    Id = "475c17c9-d7e3-48f8-8698-57b0997e286d",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole 
                {
                    Id = "7721ebeb-2b90-463f-8ebe-559110e7929b",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole 
                {
                    Id = "45a02c50-b94c-4ea8-a49f-9551a41acb84",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = "AQAAAAIAAYagAAAAEFMSjQGvVcYLAy9HxOU06eFvAOHhzqnLCxcDCn9Pr9oP2O7s3INvwJ61SPMD8TrZVg==",
                    EmailConfirmed = true,
                    SecurityStamp = "7a1b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d",
                    ConcurrencyStamp = "1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "45a02c50-b94c-4ea8-a49f-9551a41acb84",
                    UserId = "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf"
                }
            );
        }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    }

}
