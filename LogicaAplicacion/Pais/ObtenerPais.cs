using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Paises
{
    public class ObtenerPais
    {
        RepositorioPais _repositorioPais = new RepositorioPais();


        public Pais Ejecutar(int id)
        {
            return _repositorioPais.GetById(id);
        }
    }
}
