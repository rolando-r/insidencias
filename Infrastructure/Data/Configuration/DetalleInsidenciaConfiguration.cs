using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleInsidenciaConfiguration : IEntityTypeConfiguration<DetalleInsidencia>
{
    public void Configure(EntityTypeBuilder<DetalleInsidencia> builder)
    {
        builder.ToTable("DetalleInsidencias");

        builder.HasKey(p => p.IdDetalleInsidencia);
        builder.Property(p => p.IdDetalleInsidencia)
        .ValueGeneratedNever();

        builder.Property(p=> p.IdHerramienta)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.Descripcion)
        .IsRequired()
        .HasMaxLength(120);

        builder.HasOne(p => p.TipoInsidencia)
        .WithMany(e => e.DetalleInsidencias)
        .HasForeignKey(i => i.IdTipoInsidencia);

        builder.HasOne(p => p.NivelInsidencia)
        .WithMany(e => e.DetalleInsidencias)
        .HasForeignKey(i => i.IdNivelInsidencia);

        builder.HasOne(p => p.Estado)
        .WithMany(e => e.DetalleInsidencias)
        .HasForeignKey(i => i.IdEstado);
    }
}