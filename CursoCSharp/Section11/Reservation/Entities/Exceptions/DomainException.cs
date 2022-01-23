using System;


namespace CursoCSharp.Section11.Reservation.Entities.Exceptions
{
    //Criando uma exceção para o domínio do sistema
    class DomainException : ApplicationException
    {
        
        public DomainException(string message) : base(message)
        { 
            //Não entendi direito o uso de base
            
        
        }
    }
}
