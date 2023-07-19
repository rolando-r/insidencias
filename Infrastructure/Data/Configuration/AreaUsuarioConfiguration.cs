using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AreaUsuarioConfiguration : IEntityTypeConfiguration<AreaUsuario>
{
    public void Configure(EntityTypeBuilder<AreaUsuario> builder)
    {
        builder.ToTable("AreaUsuarios");

        builder.HasKey(p => p.IdAreaUsuario);
        builder.Property(p => p.IdAreaUsuario)
        .ValueGeneratedNever();

        builder.HasOne(p => p.Usuario)
        .WithMany(e => e.AreaUsuarios)
        .HasForeignKey(i => i.IdUsuario);

        builder.HasOne(p => p.Area)
        .WithMany(e => e.AreaUsuarios)
        .HasForeignKey(i => i.IdArea);
    }
}