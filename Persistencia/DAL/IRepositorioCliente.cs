﻿using Persistencia.Domain;

namespace Persistencia.DAL
{
    //una iterfaz que ademas implementa la interfaz IRepository
    //El generico se pasa una clase (Client) como indica la interfa IRepository
    interface IRepositorioCliente : IRepositorio<Cliente>
    {
        //Esta interfaz se especifica que el resositorio va a ser sobre clientes "Client" al indicar IRepository<Client>
    }
}
