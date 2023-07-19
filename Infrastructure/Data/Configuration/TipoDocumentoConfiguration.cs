using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("TipoDocumentos");

        builder.HasKey(p => p.IdTipoDocumento);
        builder.Property(p => p.IdTipoDocumento)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreTipoDocumento)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.Abreviatura)
        .IsRequired()
        .HasMaxLength(20);
    }
}