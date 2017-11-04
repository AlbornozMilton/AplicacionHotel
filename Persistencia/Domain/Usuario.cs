using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Usuario:IEquatable<Usuario>
    {
        public string UsuarioId { get; set; }
        public string Password { get; set; }

        public bool Equals(Usuario other)
        {
            if (other == null)
            {
                return false;
            }
            else if (UsuarioId.Equals(other.UsuarioId))
            {
                return (Password.Equals(other.Password));
            }
            else return false;
        }
    }
}
