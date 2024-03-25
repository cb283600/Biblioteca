using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Paises
{
    public class EditarPais
    {
        RepositorioPais _repositorioPais = new RepositorioPais();


        public void Ejecutar(int id, Pais pais)
        {
            _repositorioPais.Update(id, pais);
        }
    }
}
