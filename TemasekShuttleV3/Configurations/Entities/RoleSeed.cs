using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TemasekShuttleV3.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                //new IdentityRole //for registering new user (customer)
                //{
                //    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                //    Name = "User",
                //    NormalizedName = "USER"
                //},

                //TODO: Create a driver role here

                new IdentityRole //jovandriver
                {
                    Id = "023f7028-ebed-4d50-a0c7-fc232628a75c",
                    Name = "Jovan",
                    NormalizedName = "JOVAN"
                },

                new IdentityRole //zoeydriver
                {
                    Id = "f445a56e-14eb-4906-94d7-7af9e462dff9",
                    Name = "Zoey",
                    NormalizedName = "ZOEY"
                },

                new IdentityRole //yufengdriver
                {
                    Id = "b20b199c-9749-4f01-8b80-a5a174d9c502",
                    Name = "YuFeng",
                    NormalizedName = "YUFENG"
                },

                new IdentityRole //tristondriver
                {
                    Id = "414788fe-9218-4ce0-a736-4d28d265fdf9",
                    Name = "Triston",
                    NormalizedName = "TRISTON"
                }
                );
        }        
    }
}
