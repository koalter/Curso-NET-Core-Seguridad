# Curso-NET-Core-Seguridad

Autenticacion (credenciales)
Autenticacion (permisos)

Niveles de seguridad (Autenticacion)

Anónimo: Todos pueden acceder a los endpoints de mi web api
Basic: Base64 - SSL
Bearer: Vía token (más usado y seguro)

1. Creamos la carpeta Models, generamos nuestra clase UsuarioAplicacion
2. Creamos la carpeta Context, y generamos la clase ApplicationDbContext que usaremos de contexto para la base de datos
3. En el Startup añadimos la referencia a la base con AddDbContext
4. Generamos la identidad token
<pre><code>
services.AddIdentity<UsuarioAplicacion, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
</code></pre>
5. Añadimos la referencia del connectionString en appsettings.json
<pre><code>
"connectionStrings": {
    "defaultConnection": "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = Seguridad; Integrated Security = True"
  }
</pre></code>

# JSON WEB TOKEN - JWT - CLAIMS

* Mecanismos de seguridad: TSL o SSL

1. Generamos los modelos de UsuarioInfo y UsuarioToken
2. Generamos el controlador CuentaController para empezar a crear nuestras cuentas