using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Paises
{
    public class ObtenerPaises : IObtenerTodos<Pais>
    {
        IRepositorioPais _repositorioPais;

        // Dependency Injection (DI) constructor
        public ObtenerPaises(IRepositorioPais repositorioPais)
        {
            _repositorioPais = repositorioPais;
        }

        public IEnumerable<Pais> Ejecutar()
        {
            return _repositorioPais.GetAll();
        }
    }
}
