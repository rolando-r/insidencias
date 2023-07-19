using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.ToTable("Estados");

        builder.HasKey(p => p.IdEstado);
        builder.Property(p => p.IdEstado)
        .ValueGeneratedNever();

        builder.Property(p=> p.IdEstado)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.Descripcion)
        .IsRequired()
        .HasMaxLength(120);
    }
}