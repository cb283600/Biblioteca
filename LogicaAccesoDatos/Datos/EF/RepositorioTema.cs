using Infraestructura.Datos.Excepciones;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones.Tema;
using LogicaNegocio.InterfazRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.EF
{
    public class RepositorioTema : IRepositorioTema
    {
        // The context is a required parameter for the repository to be able to interact with the database.
        private BibliotecaContext _bibliotecaContext;

        // The constructor receives the context as a parameter.
        public RepositorioTema(BibliotecaContext bibliotecaContext)
        {
            _bibliotecaContext = bibliotecaContext;
        }

        public void Add(Tema obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }

            if (_bibliotecaContext.Temas.Any(t => t.Id == obj.Id))
            {
                throw new IdInvalidaException();
            }

            if (_bibliotecaContext.Temas.Any(t => t.Nombre == obj.Nombre))
            {
                throw new NombreInvalidaException();
            }

            obj.Validar();
            _bibliotecaContext.Temas.Add(obj);
            _bibliotecaContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Tema tema = GetById(id);
            if (tema == null)
            {
                throw new NotFoundException();
            }
            _bibliotecaContext.Temas.Remove(tema);
        }

        public IEnumerable<Tema> GetAll()
        {
            return _bibliotecaContext.Temas.ToList();
        }

        public Tema GetById(int id)
        {
            foreach (var item in _bibliotecaContext.Temas)
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
