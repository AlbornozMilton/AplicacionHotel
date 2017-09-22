using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;
namespace Persistencia.DAL.EntityFramework
{
    //En esta clase derivada se especifica que el repositorio es de Alojamiento y recibe un contexto de Hotel y no otro
    class RepositorioAlojamiento:Repositorio<Alojamiento,HotelContext>,IRepositorioAlojamiento
    {
        //Constructor: construye con la BD pasada como parametro
        // utiliza el contructor de la clase padre: Repository,el cual asigna el pContext a su atributo privado
        public RepositorioAlojamiento(HotelContext pContext): base(pContext)
        {

        }

        //IMPLEMENTACION DE METODOS ESPECIFICOS PARA CLIENTES DECLARADOS EN LA ITERFAZ IRESPOSITORIOCLIENTE 

    }
}
