namespace Core.Entities;
public class AreaUsuario
{
    public string ? IdAreaUsuario { get; set; }
    public string ? IdUsuario { get; set; }
    public Usuario ? Usuario { get; set; }
    public string ? IdArea { get; set; }
    public Area ? Area { get; set; }
}