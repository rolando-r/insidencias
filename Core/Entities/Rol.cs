namespace Core.Entities;
public class Rol
{
    public string ? IdRol { get; set; }
    public string ? NombreRol { get; set; }
    public string ? DescripcionRol { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}