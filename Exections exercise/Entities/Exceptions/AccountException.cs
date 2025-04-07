using System;

namespace Exceptions_exercise.Entities.Exceptions
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message) 
        {
        }
    }
}
