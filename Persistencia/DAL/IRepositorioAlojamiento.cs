using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    interface IRepositorioAlojamiento:IRepositorio<Alojamiento>
    {
        //metodos para alojamientos como obtener listas o campos especificos
        /* EJEMPLO
         IEnumerable<Account> GetOverdrawnAccounts(); //Overdrawn: en descubierto
         IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7); 
         */
    }
}
