using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.Excepciones
{
    public class RepositorioException : Exception
    {
        public RepositorioException() { }
        public RepositorioException(string message) : base(message) { }
    }
}
