namespace Core.Entities;
public class TipoInsidencia
{
    public string ? IdTipoInsidencia { get; set; }
    public string ? NombreTipoInsidencia { get; set; }
    public string ? DescripcionTipoInsidencia { get; set; }
    public ICollection<DetalleInsidencia> ? DetalleInsidencias { get; set; } 
}