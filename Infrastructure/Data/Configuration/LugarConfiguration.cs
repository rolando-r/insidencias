using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class LugarConfiguration : IEntityTypeConfiguration<Lugar>
{
    public void Configure(EntityTypeBuilder<Lugar> builder)
    {
        builder.ToTable("Lugares");

        builder.HasKey(p => p.IdLugar);
        builder.Property(p => p.IdLugar)
        .ValueGeneratedNever();
        
        builder.Property(p=> p.NombreLugar)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.DescripcionLugar)
        .IsRequired()
        .HasMaxLength(120);

        builder.HasOne(p => p.Area)
        .WithMany(e => e.Lugares)
        .HasForeignKey(i => i.IdArea);
    }
}