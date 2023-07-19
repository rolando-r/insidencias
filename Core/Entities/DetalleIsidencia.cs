namespace Core.Entities;
public class DetalleInsidencia
{
    public string ? IdDetalleInsidencia  { get; set; }
    public string ? IdHerramienta { get; set; }
    public string ? Descripcion { get; set; }
    public string ? IdTipoInsidencia { get; set; }
    public TipoInsidencia ? TipoInsidencia { get; set; }
    public string ? IdNivelInsidencia { get; set; }
    public NivelInsidencia ? NivelInsidencia { get; set; }
    public string ? IdEstado { get; set; } 
    public Estado ? Estado { get; set; }
    public ICollection<HerramientaTrabajo> ? HerramientaTrabajos { get; set; }
}