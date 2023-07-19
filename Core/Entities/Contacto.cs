namespace Core.Entities;
public class Contacto
{
    public string ? IdContacto { get; set; }
    public string ? IdUsuario { get; set; }
    public Usuario ? Usuario { get; set; }
    public string ? IdTipoContacto { get; set; }
    public TipoContacto ? tipoContacto { get; set; }
    public string ? IdCategoriaContacto { get; set; }
    public CategoriaContacto ? CategoriaContacto { get; set; }
    public string ? Descripcion { get; set; }
}