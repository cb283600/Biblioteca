using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Paises
{
    public class EliminarPais : IEliminar<Pais>
    {
        IRepositorioPais _repositorioPais;

        // Dependency Injection (DI) constructor
        public EliminarPais(IRepositorioPais repositorioPais)
        {
            _repositorioPais = repositorioPais;
        }

        public void Ejecutar(int id)
        {
            _repositorioPais.Delete(id);
        }
    }
}
