using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones.Pais
{
    public class NombreInvalidaException : DominioException
    {
        public NombreInvalidaException() {}
        public NombreInvalidaException(string message) : base("El nombre del pais debe ser valido") {}
    }
}
