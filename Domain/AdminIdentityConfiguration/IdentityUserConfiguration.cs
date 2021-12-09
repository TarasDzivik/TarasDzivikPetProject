using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TarasDzivikPetProject.Domain.AdminIdentityConfiguration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "t.dzivik@gmail.com",
                NormalizedEmail = "T.DZIVIK@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });
        }
    }
}