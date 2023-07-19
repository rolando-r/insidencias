using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
{
    public void Configure(EntityTypeBuilder<Contacto> builder)
    {
        builder.ToTable("Contactos");

        builder.HasKey(p => p.IdContacto);
        builder.Property(p => p.IdContacto)
        .ValueGeneratedNever();

        builder.Property(p=> p.Descripcion)
        .IsRequired()
        .HasMaxLength(120);

        builder.HasOne(p => p.Usuario)
        .WithMany(e => e.Contactos)
        .HasForeignKey(i => i.IdUsuario);

        builder.HasOne(p => p.tipoContacto)
        .WithMany(e => e.Contactos)
        .HasForeignKey(i => i.IdTipoContacto);

        builder.HasOne(p => p.CategoriaContacto)
        .WithMany(e => e.Contactos)
        .HasForeignKey(i => i.IdCategoriaContacto);
    }
}