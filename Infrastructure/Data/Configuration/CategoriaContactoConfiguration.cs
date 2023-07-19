using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CategoriaContactoConfiguration : IEntityTypeConfiguration<CategoriaContacto>
{
    public void Configure(EntityTypeBuilder<CategoriaContacto> builder)
    {
        builder.ToTable("Categorias");

        builder.HasKey(p => p.IdCategoriaContacto);
        builder.Property(p => p.IdCategoriaContacto)
        .ValueGeneratedNever();

        builder.Property(p=> p.IdCategoria)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.NombreCategoriaUsuario)
        .IsRequired()
        .HasMaxLength(20);
    }
}