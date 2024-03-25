using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Temas
{
    public class EditarTema : IEditar<Tema>
    {
        IRepositorioTema _repositorioTema;

        // Dependency Injection (DI) constructor
        public EditarTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public void Ejecutar(int id, Tema tema)
        {
            _repositorioTema.Update(id, tema);
        }
    }
}
