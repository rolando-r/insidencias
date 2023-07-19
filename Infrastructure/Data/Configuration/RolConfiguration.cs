using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Roles");

        builder.HasKey(p => p.IdRol);
        builder.Property(p => p.IdRol)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreRol)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionRol)
        .IsRequired()
        .HasMaxLength(120);
    }
}