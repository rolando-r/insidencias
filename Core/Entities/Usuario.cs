namespace Core.Entities;
public class Usuario
{
    public string ? IdUsuario { get; set;}
    public string ? NombreUsuario { get; set; }
    public string ? ApellidoUSuario { get; set; }
    public string ? DireccionUsuario { get; set; }
    public string ? IdTipoDocumento { get; set; }
    public TipoDocumento ? TipoDocumento { get; set; } 
    public string ? IdRoles { get; set; }
    public Rol ? Rol { get; set; }
    public ICollection<Insidencia> ? Insidencias { get; set; }
    public ICollection<Contacto> ? Contactos { get; set; }
    public ICollection<AreaUsuario> ? AreaUsuarios { get; set; }


}