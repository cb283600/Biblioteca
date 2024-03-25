using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace LogicaAplicacion.Temas
{
    public class AltaTema : IAlta<Tema>
    {
        IRepositorioTema _repositorioTema;

        // Dependency Injection (DI) constructor
        public AltaTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public void Ejecutar(Tema tema)
        {
            _repositorioTema.Add(tema);
        }
    }
}
