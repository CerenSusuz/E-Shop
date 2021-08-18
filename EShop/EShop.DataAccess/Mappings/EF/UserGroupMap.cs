using EShop.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;

namespace EShop.DataAccess.Mappings.EF
{
    public class UserGroupMap : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.ToTable("UserGroups");
            builder.HasIndex(x => x.Description);
            
            builder.HasData(new UserGroup {
                Id=1,
                Description = "Personel"
            });
            
            builder.HasData(new UserGroup {
                Id=2,
                Description = "Son kullanıcı"
            });
            
            
        }
    }
}