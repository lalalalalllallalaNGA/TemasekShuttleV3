using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba", //admin role
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"  //admin user
                },

                // TODO: create driver-user mapping here

                new IdentityUserRole<string> //jovandriver
                {
                    RoleId = "023f7028-ebed-4d50-a0c7-fc232628a75c",
                    UserId = "78c9271b-e508-4214-b105-b448185b1010"
                },

                new IdentityUserRole<string> //zoeydriver
                {
                    RoleId = "f445a56e-14eb-4906-94d7-7af9e462dff9",
                    UserId = "363dd9c6-47c2-4759-bbfc-25701e3ff1049"
                },

                new IdentityUserRole<string> //yufengdriver
                {
                    RoleId = "b20b199c-9749-4f01-8b80-a5a174d9c502",
                    UserId = "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8"
                },

                new IdentityUserRole<string> //tristondriver
                {
                    RoleId = "414788fe-9218-4ce0-a736-4d28d265fdf9",
                    UserId = "18893c71-425e-426e-8cc5-13f24d3fdc3f"
                }
                );
        }
    }
}
