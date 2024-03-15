using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones
{
    public abstract class DominioException: Exception
    {
        public DominioException() { }
        public DominioException(string message) : base(message) { }
    }
}
