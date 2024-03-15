
using LogicaAccesoDatos.Excepciones;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;

namespace LogicaAccesoDatos.Listas
{
    public class RepositorioPais : IRepositorioPais
    {
        private static List<Pais> _pais = new List<Pais>();

        public void Add(Pais obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }
            obj.Validar();
            _pais.Add(obj);
        }

        public void Delete(int id)
        {
            Pais pais = GetById(id);
            if (pais == null)
            {
                throw new NotFoundException();
            }
            _pais.Remove(pais);
        }

        public IEnumerable<Pais> GetAll()
        {
            return _pais;
        }

        public Pais GetById(int id)
        {
            foreach (var item in _pais)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<Pais> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pais obj)
        {
            Pais pais = GetById(id);
            if (pais == null)
            {
                throw new NotFoundException();
            }
            pais.Update(obj);
        }
    }
}
