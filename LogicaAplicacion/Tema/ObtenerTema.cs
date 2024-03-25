using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Temas
{
    public class ObtenerTema : IObtener<Tema>
    {
        IRepositorioTema _repositorioTema;

        // Dependency Injection (DI) constructor
        public ObtenerTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public Tema Ejecutar(int id)
        {
            return _repositorioTema.GetById(id);
        }
    }
}
