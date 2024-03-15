using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones.Tema
{
    public class IdInvalidaException : DominioException
    {
        public IdInvalidaException() { }
        public IdInvalidaException(string message) : base("El ID debe ser valido") { }

    }
}