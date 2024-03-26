using Infraestructura.Datos.Excepciones;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones.Tema;
using LogicaNegocio.InterfazRepositorio;

namespace Infraestructura.Datos.Listas
{
    public class RepositorioTema : IRepositorioTema
    {
        private static List<Tema> _temas = new List<Tema>();


        public void Add(Tema obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }

            if (_temas.Any(t => t.Id == obj.Id))
            {
                throw new IdInvalidaException();
            }

            if (_temas.Any(t => t.Nombre == obj.Nombre))
            {
                throw new NombreInvalidaException();
            }

            obj.Validar();
            _temas.Add(obj);
        }

        public void Delete(int id)
        {
            Tema tema = GetById(id);
            if (tema == null)
            {
                throw new NotFoundException();
            }
            _temas.Remove(tema);
        }

        public IEnumerable<Tema> GetAll()
        {
            return _temas;
        }

        public Tema GetById(int id)
        {
            foreach (var item in _temas)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<Tema> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Tema obj)
        {
            Tema tema = GetById(id);
            if (tema == null)
            {
                throw new NotFoundException();
            }
            tema.Update(obj);
        }

    }
}
