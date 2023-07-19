namespace Core.Entities;
public class HerramientaTrabajo
{
    public string ? IdHerramienta {get; set; }
    public string ? NombreHerramienta { get; set; }
    public ICollection<DetalleInsidencia> ? DetalleInsidencias { get; set; }
}