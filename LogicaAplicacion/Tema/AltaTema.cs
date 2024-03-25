using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Temas
{
    public class AltaTema
    {
        RepositorioTema _repositorioTema = new RepositorioTema();


        public void Ejecutar(Tema tema)
        {
            _repositorioTema.Add(tema);
        }
    }
}
