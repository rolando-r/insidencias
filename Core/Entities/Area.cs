namespace Core.Entities;
public class Area
{
    public string ? IdArea { get; set; }
    public string ?  NombreArea { get; set; }
    public string ? DescripcionArea { get; set; }
    public ICollection<Lugar> ? Lugares { get; set; }
    public ICollection<Insidencia> ? Insidencias { get; set; }

}