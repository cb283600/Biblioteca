using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Temas
{
    public class EliminarTema : IEliminar<Tema>
    {
        IRepositorioTema _repositorioTema;

        // Dependency Injection (DI) constructor
        public EliminarTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public void Ejecutar(int id)
        {
            _repositorioTema.Delete(id);
        }
    }
}
