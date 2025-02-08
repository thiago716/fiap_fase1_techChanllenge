using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configuration.Mapping;
public class DirectDistanceDialingDbMap : IEntityTypeConfiguration<DirectDistanceDialing>
{
    public void Configure(EntityTypeBuilder<DirectDistanceDialing> builder)
    {
        builder.ToTable("DirectDistanceDialing");

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
            .ValueGeneratedNever();

        builder.Property(d => d.CreatedOn)
            .IsRequired()
            .HasColumnType("DATETIME2")
            .HasDefaultValue(DateTime.Now.ToUniversalTime());
        
        builder.Property(d => d.Region)
            .IsRequired()
            .HasMaxLength(50);
    }
}
