using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFixacao.Execeptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
