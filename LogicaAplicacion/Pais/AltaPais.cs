using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Paises
{
    public class AltaPais
    {
        RepositorioPais _repositorioPais = new RepositorioPais();


        public void Ejecutar(Pais pais)
        {
            _repositorioPais.Add(pais);
        }
    }
}
