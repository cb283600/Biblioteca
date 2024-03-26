using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.Excepciones
{
    public class NotFoundException : RepositorioException
    {
        public NotFoundException() : base("No se encontró la información solicitada.") { }

    }
}
