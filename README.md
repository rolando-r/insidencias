# Creación del proyecto

   Cree una Carpeta principal en la cual se crearan los proyectos internos para la generación del WebApi

------

- ​       Ejecute comando **dotnet new sln** : Genera la solucion principal.

- ​       Ejecute el comando **dotnet new webapi –-output API** : Para crear el proyecto WebApi
- ​       dotnet sln add (Solucion Agregar) ex. dotnet sln add .\API\

- ​       Ejecute el comando : **dotnet new classlib –o Core**
- ​       Ejecute el comando : **dotnet new classlib –o Infrastructure**

- ​       Agregue los proyectos Core e Infrastructure:
    ​    ​    **dotnet sln add** .\Core\
    ​    ​    **dotnet sln add** .\Infrastructure\
    
- ​      Ejecute el comando : **dotnet sln list** -> Para visualizar los proyectos agregados a la solucion

  ```tex
  Proyectos    
  API\API.csproj
  Core\Core.csproj
  Infrastructure\Infrastructure.csproj
  PS D:\projectsNetCore\bodegas>
  ```

------

- Establezca referencia entre los proyectos Infraestructure y Core.

  ```tex
  PS D:\projectsNetCore\bodegas> cd .\Infrastructure\
  PS D:\projectsNetCore\bodegas\Infrastructure> dotnet add reference ..\Core\
  Se ha agregado la referencia "..\Core\Core.csproj" al proyecto.
  PS D:\projectsNetCore\bodegas\Infrastructure>
  ```

  Establezca referencia entre Api e Infrastructure

  ```tex
  PS D:\projectsNetCore\bodegas> cd .\API\
  PS D:\projectsNetCore\bodegas\API> dotnet add reference ..\Infrastructure\
  ```
  
  # Instalaciones Necesarias

1. Instale el paquete de EntityCore ingrese a la url https://www.nuget.org/packages/Microsoft.EntityFrameworkCore En la terminal. El comando se debe ejecutar dentro de la carpeta **Infrastructure y API**.


   ```tex
   dotnet add package Microsoft.EntityFrameworkCore --version 7.0.8
   ```

3. Instale el paquete de Mysql dentro de **Infrastructure** para configurar la conexion a la base de datos. https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql Ejecute el siguiente comando desde la terminal.

   ```tex
   dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
   ```
 
4. Instale el paquete design dentro de **API** para poder hacer las migraciones. https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design . Ejecute el siguiente comando desde la terminal.
   ```tex
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.9
   ```
# Configuracion de la conexion a Mysql

1. En el archivo appsettings.Development.json agregar el parametro ConnectionStrings:

   ```json
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "ConnectionStrings": {
       "DefaultConnection":"server=localhost;user=root;password=123456;database=inventariodb"
     }
   }
   ```

   

------

# Creando clase de contexto

La clase de contexto se crea en el proyecto Infrastructure/Data. Se recomienda que el nombre de la clase de contexto inicie con el nombre del proyecto. Para el ejemplo **BodegasContext**

```c#
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class BodegasContext : DbContext
{
     public BodegasContext(DbContextOptions<BodegasContext> options) : base(options)
    {
    }       
}
```

En el archivo Program.cs que se encuentra en el proyecto API pegar el siguiente codigo:

```c#
builder.Services.AddDbContext<BodegasContext>(options =>
{
    string ? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
```

Nota : Se recomienda insertar despues de la linea de codigo:

```c#
builder.Services.AddControllers();
```

Nota: Recuerde realizar la importaciones de librerias using

```c#
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
```

# Creando Entidades y Configurations

- ​       Crea la carpeta **Entities** dentro de Core y haz las entidades requeridas.

**Entidad:** 

```c#
namespace Core.Entities;
public class Insidencia
{
    public string ? IdInsidencia { get; set; }
    public string ? IdEstado { get; set; }
    public Estado ? Estado { get; set; }
    public ICollection<Area> ? Areas { get; set; }
}
```

- ​       Crea la carpeta **Data** dentro de infrastructure.
- ​       Crea la carpeta **Configuration** dentro de Data y haz la configuracion de cada una de las entidades.

```c#
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
{
    public void Configure(EntityTypeBuilder<Contacto> builder)
    {
        builder.ToTable("Contactos");

        builder.HasKey(p => p.IdContacto);
        builder.Property(p => p.IdContacto)
        .ValueGeneratedNever();

        builder.Property(p=> p.Descripcion)
        .IsRequired()
        .HasMaxLength(120);

        builder.Property(p=> p.FechaInsidencia)
        .IsRequired()
        .HasColumnType("date");

        builder.HasOne(p => p.Usuario)
        .WithMany(e => e.Contactos)
        .HasForeignKey(i => i.IdUsuario);
    }
}
```
  
- ​       Crea el archivo **NameDbContext** que permite la conexion a la base de datos.

```c#
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class InsidenciasContext : DbContext
{
    public InsidenciasContext(DbContextOptions<InsidenciasContext> options) : base(options)
    {
    }
    public DbSet<Area> Areas { get; set; }
    public DbSet<AreaUsuario> AreaUsuarios { get; set; }
    public DbSet<CategoriaContacto> CategoriaContactos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
```

- ​       Para la creación de las migraciones
**dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations**

- ​       Aplicar la migracion a la base de datos:
dotnet ef database update --project ./Infrastructure/ --startup-project ./API/  
