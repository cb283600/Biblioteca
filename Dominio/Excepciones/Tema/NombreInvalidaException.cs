using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones.Tema
{
    public class NombreInvalidaException : DominioException
    {
        public NombreInvalidaException(){ }
        public NombreInvalidaException(string message) : base("El nombre no puede ser nulo y debe contener minimo 2 caracteres"){ }
    }
}
