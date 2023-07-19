using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class NivelInsidenciaConfiguration : IEntityTypeConfiguration<NivelInsidencia>
{
    public void Configure(EntityTypeBuilder<NivelInsidencia> builder)
    {
        builder.ToTable("NivelInsidencias");

        builder.HasKey(p => p.IdNivelInsidencia);
        builder.Property(p => p.IdNivelInsidencia)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreNivelInsidencia)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionNivelInsidencia)
        .IsRequired()
        .HasMaxLength(120);
    }
}