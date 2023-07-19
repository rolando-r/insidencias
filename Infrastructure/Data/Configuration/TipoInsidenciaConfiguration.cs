using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoInsidenciaConfiguration : IEntityTypeConfiguration<TipoInsidencia>
{
    public void Configure(EntityTypeBuilder<TipoInsidencia> builder)
    {
        builder.ToTable("TipoInsidencias");

        builder.HasKey(p => p.IdTipoInsidencia);
        builder.Property(p => p.IdTipoInsidencia)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreTipoInsidencia)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionTipoInsidencia)
        .IsRequired()
        .HasMaxLength(120);
    }
}