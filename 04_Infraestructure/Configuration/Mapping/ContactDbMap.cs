using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configuration.Mapping;
public class ContactDbMap : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contact");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();
                
        builder.Property(c => c.CreatedOn)
            .IsRequired()
            .HasColumnType("DATETIME2")
            .HasDefaultValue(DateTime.Now.ToUniversalTime());

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(255);
        
        builder.HasOne(c => c.Ddd)
            .WithMany(d => d.Contacts)
            .HasConstraintName("FK_Contact_DirectDistanceDialing");
    }
}
