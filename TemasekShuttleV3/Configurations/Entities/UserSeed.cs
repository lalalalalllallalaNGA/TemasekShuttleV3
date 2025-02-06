using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TemasekShuttleV3.Data;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<TemasekShuttleV3User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TemasekShuttleV3User> builder)
        {
            var hasher = new PasswordHasher<TemasekShuttleV3User>();
            builder.HasData(
                new TemasekShuttleV3User
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login 
                },
            
                //TODO: Create a driver user here
                new TemasekShuttleV3User
                {
                    Id = "78c9271b-e508-4214-b105-b448185b1010",
                    Email = "jovan@localhost.com",
                    NormalizedEmail = "JOVAN@LOCALHOST.COM",
                    FirstName = "Jovan",
                    LastName = "Driver",
                    UserName = "jovan@localhost.com",
                    NormalizedUserName = "JOVAN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login 
                }, 
               
                new TemasekShuttleV3User
                {
                    Id = "363dd9c6-47c2-4759-bbfc-25701e3ff1049",
                    Email = "zoey@localhost.com",
                    NormalizedEmail = "ZOEY@LOCALHOST.COM",
                    FirstName = "Zoey",
                    LastName = "Driver",
                    UserName = "zoey@localhost.com",
                    NormalizedUserName = "ZOEY@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword3"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login 
                },

                new TemasekShuttleV3User
                {
                    Id = "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8",
                    Email = "yufeng@localhost.com",
                    NormalizedEmail = "YUFENG@LOCALHOST.COM",
                    FirstName = "YuFeng",
                    LastName = "Driver",
                    UserName = "yufeng@localhost.com",
                    NormalizedUserName = "YUFENG@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword4"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login 
                },
                new TemasekShuttleV3User
                {
                    Id = "18893c71-425e-426e-8cc5-13f24d3fdc3f",
                    Email = "Triston@localhost.com",
                    NormalizedEmail = "TRISTON@LOCALHOST.COM",
                    FirstName = "Triston",
                    LastName = "Driver",
                    UserName = "triston@localhost.com",
                    NormalizedUserName = "TRISTON@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword5"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login 
                }
                );
        }
    }
}
