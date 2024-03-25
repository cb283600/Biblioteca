using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Temas
{
    public class EliminarTema
    {
        RepositorioTema _repositorioTema = new RepositorioTema();


        public void Ejecutar(int id)
        {
            _repositorioTema.Delete(id);
        }
    }
}
