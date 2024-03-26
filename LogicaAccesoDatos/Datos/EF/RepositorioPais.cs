using Infraestructura.Datos.Excepciones;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones.Pais;
using LogicaNegocio.InterfazRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.EF
{
    public class RepositorioPais : IRepositorioPais
    {
        private BibliotecaContext _bibliotecaContext;

        public RepositorioPais(BibliotecaContext bibliotecaContext)
        {
            _bibliotecaContext = bibliotecaContext;
        }

        public void Add(Pais obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }
            if (_bibliotecaContext.Paises.Any(p => p.Id == obj.Id))
            {
                throw new IdInvalidaException();
            }

            if (_bibliotecaContext.Paises.Any(p => p.Nombre == obj.Nombre))
            {
                throw new NombreInvalidaException();
            }
            obj.Validar();
            _bibliotecaContext.Paises.Add(obj);
            _bibliotecaContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Pais pais = GetById(id);
            if (pais == null)
            {
                throw new NotFoundException();
            }
            _bibliotecaContext.Paises.Remove(pais);
            _bibliotecaContext.SaveChanges();
        }

        public IEnumerable<Pais> GetAll()
        {
            return _bibliotecaContext.Paises.ToList();
        }

        public Pais GetById(int id)
        {
            foreach (var item in _bibliotecaContext.Paises)
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
            _bibliotecaContext.SaveChanges();
        }
    }
}
