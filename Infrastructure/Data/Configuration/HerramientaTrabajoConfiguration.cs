using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class HerramientaTrabajoConfiguration : IEntityTypeConfiguration<HerramientaTrabajo>
{
    public void Configure(EntityTypeBuilder<HerramientaTrabajo> builder)
    {
        builder.ToTable("HerramientaTrabajos");

        builder.HasKey(p => p.IdHerramienta);
        builder.Property(p => p.IdHerramienta)
        .ValueGeneratedNever();

        builder.Property(p=> p.IdHerramienta)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.NombreHerramienta)
        .IsRequired()
        .HasMaxLength(20);
    }
}