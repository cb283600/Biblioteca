using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones.Pais
{
    public class CantHabitantesInvalidaException : DominioException
    {
        public CantHabitantesInvalidaException() { }
        public CantHabitantesInvalidaException(string message) : base("La cantidad de habitantes debe ser valida") { }

    }
}
