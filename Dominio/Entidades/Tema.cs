using Dominio.Excepciones.Tema;
using Dominio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Tema : IValidable
    {
        public Tema() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }

        public void Validar()
        {
            ValidarId();
            ValidarNombre();
            ValidarDescription();
        }

        public void ValidarId()
        {
            if (Id <= 0) { throw new IdInvalidaException("El Id es inválido"); }
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre) || Nombre.Length <= 2) { throw new NombreInvalidaException("El Nombre es inválido"); }
        }

        public void ValidarDescription()
        {
            if (string.IsNullOrEmpty(Description)) { throw new DescriptionInvalidaException("La Descripción es inválida"); }
        }

    }
}
