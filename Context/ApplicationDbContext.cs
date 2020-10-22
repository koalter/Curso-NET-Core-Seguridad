using Curso_NET_Core_Seguridad.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_NET_Core_Seguridad.Context
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioAplicacion>
    {
        // JSON WEB TOKEN (JWT)

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
