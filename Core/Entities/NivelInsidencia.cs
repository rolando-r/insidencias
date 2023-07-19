namespace Core.Entities;
public class NivelInsidencia
{
    public string ? IdNivelInsidencia { get; set; }
    public string ? NombreNivelInsidencia { get; set; }
    public string ? DescripcionNivelInsidencia { get; set; }
    public ICollection<DetalleInsidencia> ? DetalleInsidencias { get; set; }
}