using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_NET_Core_Seguridad.Models
{
    public class UsuarioToken
    {
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
