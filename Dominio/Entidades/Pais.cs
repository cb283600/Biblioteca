using System;
using Dominio.InterfacesDominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Excepciones.Pais;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio.Entidades
{
    public class Pais : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantHabitantes { get; set; }

        public Pais()
        {
        }

        public void Validar()
        {
            ValidarId();
            ValidarNombre();
            ValidarCantHabitantes();
        }

        private void ValidarId()
        {
            if (Id <= 0)
            {
                throw new IdInvalidaException("El Id debe ser mayor a cero.");
            }
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new NombreInvalidaException("El Nombre no puede ser nulo o vacío.");
            }
        }

        private void ValidarCantHabitantes()
        {
            if (CantHabitantes <= 0)
            {
                throw new CantHabitantesInvalidaException("La cantidad de habitantes debe ser mayor a cero.");
            }
        }
    }

}
