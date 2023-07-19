using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        builder.HasKey(p => p.IdUsuario);
        builder.Property(p => p.IdUsuario)
        .ValueGeneratedNever();

        builder.Property(p=> p.NombreUsuario)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.ApellidoUSuario)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DireccionUsuario)
        .IsRequired()
        .HasMaxLength(120);

        builder.Property(p=> p.ApellidoUSuario)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasOne(p => p.TipoDocumento)
        .WithMany(e => e.Usuarios)
        .HasForeignKey(i => i.IdTipoDocumento);

        builder.HasOne(p => p.Rol)
        .WithMany(e => e.Usuarios)
        .HasForeignKey(i => i.IdRoles);
    }
}