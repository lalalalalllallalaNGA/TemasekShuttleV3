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
                    RoleId = "cc929e90-2902-4d56-b9b3-663d1acba20f", //driver role
                    UserId = "78c9271b-e508-4214-b105-b448185b1010"  //jovan user
                },

                new IdentityUserRole<string> //zoeydriver
                {
                    RoleId = "cc929e90-2902-4d56-b9b3-663d1acba20f",//driver role
                    UserId = "363dd9c6-47c2-4759-bbfc-25701e3ff1049"//zoey user
                },

                new IdentityUserRole<string> //yufengdriver
                {
                    RoleId = "cc929e90-2902-4d56-b9b3-663d1acba20f",//driver role
                    UserId = "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8"//yufeng user
                },

                new IdentityUserRole<string> //tristondriver
                {
                    RoleId = "cc929e90-2902-4d56-b9b3-663d1acba20f",//driver role
                    UserId = "18893c71-425e-426e-8cc5-13f24d3fdc3f"//triston user
                }
                );
        }
    }
}
