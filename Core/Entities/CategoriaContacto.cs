namespace Core.Entities;
public class CategoriaContacto
{
    public string ? IdCategoriaContacto { get; set; }
    public string ? IdCategoria { get; set; }
    public string ? NombreCategoriaUsuario { get; set; }
    public ICollection<Contacto> ? Contactos { get; set; }
}