using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_145_Exercicios_TryCatch.Entities
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
