namespace Core.Entities;
public class Lugar
{
    public string ? IdLugar { get; set; }
     public string ? NombreLugar{ get; set; }
     public string ? DescripcionLugar { get; set; }
     public string ? IdArea { get; set; }
     public Area ? Area { get; set; }
     public ICollection <AreaUsuario> ? AreaUsuarios { get; set;}
}