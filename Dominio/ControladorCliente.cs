using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladorCliente
    {
        public Cliente NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {
            return (new Cliente(Convert.ToInt32(pDni),pNombre,pApellido,pTel));
        }
    }
}
