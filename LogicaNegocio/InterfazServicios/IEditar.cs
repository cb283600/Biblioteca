
using LogicaNegocio.Entidades;

namespace LogicaNegocio.InterfazServicios
{
    public interface IEditar<T>
    {
        public void Ejecutar(int id, T obj);
    }
}
