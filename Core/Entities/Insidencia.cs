namespace Core.Entities;
public class Insidencia
{
    public string ? IdInsidencia { get; set; }
    public string ? IdEstado { get; set; }
    public Estado ? Estado { get; set; }
    public string ? IdUsuario { get; set; }
    public Usuario ? Usuario {get; set; }
    public string ? IdArea { get; set; }
    public Area ? Area { get; set; }
    public string ? IdLugar { get; set; }
    public Lugar ? Lugar { get; set; }
    public string ? DescripcionInsidencia { get; set; }
    public DateTime FechaInsidencia { get; set; }
    public ICollection<Area> ? Areas { get; set; }
    
}