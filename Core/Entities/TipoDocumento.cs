namespace Core.Entities;
public class TipoDocumento
{
    public string ? IdTipoDocumento { get; set; }
    public string ? NombreTipoDocumento { get; set; }
    public string ? Abreviatura { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}