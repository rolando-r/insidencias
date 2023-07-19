namespace Core.Entities;
public class Estado
{
    public string ? IdEstado { get; set; }
    public string ? Descripcion { get; set; }
    public ICollection<DetalleInsidencia> ? DetalleInsidencias { get; set; }
}