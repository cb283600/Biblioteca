using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones.Tema
{
    public class DescriptionInvalidaException : DominioException
    {
        public DescriptionInvalidaException(){ }
        public DescriptionInvalidaException(string message) : base("La descripcion debe ser valida"){ }
    }
}
