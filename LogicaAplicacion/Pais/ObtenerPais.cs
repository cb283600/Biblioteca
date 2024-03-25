using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Paises
{
    public class ObtenerPais : IObtener<Pais>
    {
        IRepositorioPais _repositorioPais;

        // Dependency Injection (DI) constructor
        public ObtenerPais(IRepositorioPais repositorioPais)
        {
            _repositorioPais = repositorioPais;
        }

        public Pais Ejecutar(int id)
        {
            return _repositorioPais.GetById(id);
        }
    }
}
