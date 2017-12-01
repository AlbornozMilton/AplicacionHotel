using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public interface IForm
    {
        //ESTA INTERFAZ PODRIA LLEGAR A SER USADA SI SE UTILIZA MUCHO EL EXTRAER CLIENTE O ALGUN METODO COMUN.
        //QUE POR LAS DUDAS. VER TUTORIAL WORD...

        //void cargar_Nro_Habitacion(int nroHab); //PODRIA LLEGAR A USARSE
        void Extraer_Cliente();

    }
}
