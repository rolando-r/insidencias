# Proyecto insidencias

# Creación del proyecto

   Cree una Carpeta principal en la cual se crearan los proyectos internos para la generación del WebApi

------

- ​       Ejecute comando **dotnet new sln** : Genera la solucion principal.

- ​       Ejecute el comando **dotnet new webapi –-output API** : Para crear el proyecto WebApi
- ​       dotnet sln add (Solucion Agregar) ex. **dotnet sln add .\API\**

- ​       Ejecute el comando : **dotnet new classlib –o Core**
- ​       Ejecute el comando : **dotnet new classlib –o Infrastructure**

- ​       Agregue los proyectos Core e Infrastructure:
    ​    ​    **dotnet sln add** .\Core\
    ​    ​    **dotnet sln add** .\Infrastructure\
    
- ​      Ejecute el comando : **dotnet sln list** -> Para visualizar los proyectos agregados a la solucion

------

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

1. Instale el paquete de EntityCore ingrese a la url https://www.nuget.org/packages/Microsoft.EntityFrameworkCore

2. Copie el comando 

   ```tex
   dotnet add package Microsoft.EntityFrameworkCore --version 7.0.8
   ```

   En la terminal del sistema operativo o en la terminal de visual studio code. El comando se debe ejecutar dentro de la carpeta **Infrastructure y API**.

3. Instale el paquete de Mysql para configurar la conexion a la base de datos. https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql Ejecute el siguiente comando desde la terminal.

   ```tex
   dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
   ```
 
4. Instale el paquete el design. https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design . Ejecute el siguiente comando desde la terminal.
   ```tex
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.9
   ```
