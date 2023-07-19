using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InsidenciaConfiguration : IEntityTypeConfiguration<Insidencia>
{
    public void Configure(EntityTypeBuilder<Insidencia> builder)
    {
        builder.ToTable("Insidencias");

        builder.HasKey(p => p.IdInsidencia);
        builder.Property(p => p.IdInsidencia)
        .ValueGeneratedNever();

        builder.Property(p=> p.DescripcionInsidencia)
        .IsRequired()
        .HasMaxLength(120);

        builder.Property(p=> p.FechaInsidencia)
        .IsRequired()
        .HasColumnType("date");

        builder.HasOne(p => p.Estado)
        .WithMany(e => e.Insidencias)
        .HasForeignKey(i => i.IdEstado);

        builder.HasOne(p => p.Usuario)
        .WithMany(e => e.Insidencias)
        .HasForeignKey(i => i.IdUsuario);

        builder.HasOne(p => p.Area)
        .WithMany(e => e.Insidencias)
        .HasForeignKey(i => i.IdArea);

        builder.HasOne(p => p.Lugar)
        .WithMany(e => e.Insidencias)
        .HasForeignKey(i => i.IdLugar);
    }
}