using _002_MyFirstBaltaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _002_MyFirstBaltaAPI.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("NVarchar")
                .HasMaxLength(128);

            //indices
            builder.HasIndex(x => x.Id,"IX_User_ID")
                .IsUnique();
                
            throw new NotImplementedException();
        }
    }
}
