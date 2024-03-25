using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Temas
{
    public class ObtenerTema
    {
        RepositorioTema _repositorioTema = new RepositorioTema();


        public Tema Ejecutar(int id)
        {
            return _repositorioTema.GetById(id);
        }
    }
}
