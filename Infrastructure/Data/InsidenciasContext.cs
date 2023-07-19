using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class InsidenciasContext : DbContext
{
    public InsidenciasContext(DbContextOptions<InsidenciasContext> options) : base(options)
    {
    }
    public DbSet<Area> Areas { get; set; }
    public DbSet<AreaUsuario> AreaUsuarios { get; set; }
    public DbSet<CategoriaContacto> CategoriaContactos { get; set; }
    public DbSet<Contacto> Contactos { get; set; }
    public DbSet<DetalleInsidencia> DetalleInsidencias { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<HerramientaTrabajo> HerramientaTrabajos { get; set; }
    public DbSet<Insidencia> Insidencias { get; set; }
    public DbSet<Lugar> Lugares { get; set; }
    public DbSet<NivelInsidencia> NivelInsidencias { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<TipoContacto> TipoContactos { get; set; }
    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    public DbSet<TipoInsidencia> TipoInsidencias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}