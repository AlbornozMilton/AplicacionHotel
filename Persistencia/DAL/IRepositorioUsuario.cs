﻿using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioUsuario:IRepositorio<Usuario>
    {
		/// <summary>
		/// Retorna Usuario Modificado o Excepciones 
		/// </summary>
		void ModifcarUsuario(string pUsuarioID, string pOldPass, string pNewPass);
		void EliminarUsuario(string pUsuarioID, string pPass);
		void NuevoUsuario(string pUsuarioID, string pPass);
    }
}
