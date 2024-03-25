using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Paises
{
    public class AltaPais : IAlta<Pais>
    {
        IRepositorioPais _repositorioPais;

        // Dependency Injection (DI) constructor
        public AltaPais(IRepositorioPais repositorioPais)
        {
            _repositorioPais = repositorioPais;
        }

        public void Ejecutar(Pais pais)
        {
            _repositorioPais.Add(pais);
        }
    }
}
