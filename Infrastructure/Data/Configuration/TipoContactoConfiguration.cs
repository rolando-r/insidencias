using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoContactoConfiguration : IEntityTypeConfiguration<TipoContacto>
{
    public void Configure(EntityTypeBuilder<TipoContacto> builder)
    {
        builder.ToTable("TipoContactos");

        builder.HasKey(p => p.IdTipoContacto);
        builder.Property(p => p.IdTipoContacto)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreTipoContacto)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionTipoContacto)
        .IsRequired()
        .HasMaxLength(120);
    }
}