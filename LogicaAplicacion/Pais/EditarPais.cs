using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Paises
{
    public class EditarPais : IEditar<Pais>
    {
        IRepositorioPais _repositorioPais;

        // Dependency Injection (DI) constructor
        public EditarPais(IRepositorioPais repositorioPais)
        {
            _repositorioPais = repositorioPais;
        }

        public void Ejecutar(int id, Pais pais)
        {
            _repositorioPais.Update(id, pais);
        }
    }
}
