using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Temas
{
    public class ObtenerTemas : IObtenerTodos<Tema>
    {
        IRepositorioTema _repositorioTema;

        // Dependency Injection (DI) constructor
        public ObtenerTemas(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public IEnumerable<Tema> Ejecutar()
        {
            return _repositorioTema.GetAll();
        }
    }
}
