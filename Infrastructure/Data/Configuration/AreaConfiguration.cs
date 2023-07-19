using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.ToTable("Areas");

        builder.HasKey(p => p.IdArea);
        builder.Property(p => p.IdArea)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreArea)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionArea)
        .IsRequired()
        .HasMaxLength(120);
    }
}