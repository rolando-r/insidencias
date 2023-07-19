namespace Core.Entities;
public class TipoContacto
{
    public string ? IdTipoContacto { get; set; }
    public string ? NombreTipoContacto { get; set; }
    public string ? DescripcionTipoContacto { get; set; }
    public ICollection<Contacto> ? Contactos { get; set; }
}