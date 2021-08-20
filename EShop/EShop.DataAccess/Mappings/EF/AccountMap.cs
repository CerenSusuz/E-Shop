using EShop.Core.Helpers;
using EShop.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.DataAccess.Mappings.EF
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => new {x.FirstName, x.LastName});
            builder.HasIndex(x => x.Gsm);

            HashingHelper.CreatePasswordHash("1234",out var passwordHash,out var passwordSalt);
            builder.HasData(new Account
            {
                Id=1,
                FirstName="Ceren",
                LastName = "Susuz",
                Email="ceren199704@hotmail.com",
                Gsm = "5541172005",
                IsSuperVisor = true,
                UserGroupId = 1,
                GenderId=1,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedUser = "Migration"
            });
        }
    }
}