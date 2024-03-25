using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Paises
{
    public class ObtenerPaises
    {
        RepositorioPais _repositorioPais = new RepositorioPais();


        public IEnumerable<Pais> Ejecutar()
        {
            return _repositorioPais.GetAll();
        }
    }
}
