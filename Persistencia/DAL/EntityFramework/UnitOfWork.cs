using System;

namespace Persistencia.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        //atributo para utilizar un solo Contexto
        protected readonly HotelContext iDbContext;

        //Constructor
        public UnitOfWork(HotelContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            //asigna el contexto 
            this.iDbContext = pContext;

            //SE UTILIZA LOS GETTERS!! ¿?--------------sin atributo ??? iClientRepository???
            //SE INSTANCIA CON TODAS LAS IMPLEMENTACIONES DEFINIDAS
            this.RepositorioAlojamiento = new RepositorioAlojamiento(this.iDbContext); //porque el this???-->por el constructor de ClientRepository
            this.RepositorioCliente = new RepositorioCliente(this.iDbContext); //porque el this???-->por el constructor de AccountRepository
            this.RepositorioCiudad = new RepositorioCiudad(this.iDbContext);
            this.RepositorioDomicilio = new RepositorioDomicilio(this.iDbContext);
            this.RepositorioUsuario = new RepositorioUsuario(this.iDbContext);
            this.RepositorioTarifa = new RepositorioTarifa(this.iDbContext);
            this.RepositorioHabitacion = new RepositorioHabitacion(this.iDbContext);
        }


        // GETTERS - IMPLEMENTACION DE IUNITOFWORK

        public IRepositorioAlojamiento RepositorioAlojamiento { get; private set; }
        public IRepositorioCliente RepositorioCliente { get; private set; }
        public IRepositorioCiudad RepositorioCiudad { get; private set; }
        public IRepositorioDomicilio RepositorioDomicilio { get; private set; }
        public IRepositorioUsuario RepositorioUsuario { get; private set; }
        public IRepositorioTarifa RepositorioTarifa{ get; private set; }
        public IRepositorioHabitacion RepositorioHabitacion{ get; private set; }


        /// <summary>
        /// Realiza el método SaveChanges();
        /// </summary>
        //implementacion de IUnitOfWork 
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        /// <summary>
        ///Implementación de IDisposable: Define el método Dispose para liberar recursos no administrados.
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    
    }
}
