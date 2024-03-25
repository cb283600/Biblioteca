using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Temas
{
    public class ObtenerTemas
    {
        RepositorioTema _repositorioTema = new RepositorioTema();


        public IEnumerable<Tema> Ejecutar()
        {
            return _repositorioTema.GetAll();
        }
    }
}
