using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using backend.Data.Entities;

namespace backend.Data.Configurations;

public class WarehouseSectionConfiguration : IEntityTypeConfiguration<WarehouseSection>
{
    public void Configure(EntityTypeBuilder<WarehouseSection> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
          .IsRequired()
          .HasMaxLength(36)
          .IsUnicode(false)
          .IsFixedLength()
          .HasColumnType("char(36)")
          .HasDefaultValueSql("NEWID()");
        builder.HasIndex(e => e.Id).IsUnique();
        builder.Property(e => e.Name).IsRequired().HasMaxLength(255);
    }
}