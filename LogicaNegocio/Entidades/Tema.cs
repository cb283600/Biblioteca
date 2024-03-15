using LogicaNegocio.Excepciones.Tema;
using LogicaNegocio.IntefacesDominio;
using System.ComponentModel.DataAnnotations;

namespace LogicaNegocio.Entidades
{
	public class Tema : IValidable
	{
		public Tema() { }

		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		public void Validar()
		{
			ValidarId();
			ValidarNombre();
			ValidarDescripcion();
		}

		public void ValidarId()
		{
			if (Id <= 0) { throw new IdInvalidaException(); }
		}

		private void ValidarNombre()
		{
			if (string.IsNullOrEmpty(Nombre) || Nombre.Length <= 2) { throw new NombreInvalidaException(); }
		}

		private void ValidarDescripcion()
		{
			if (string.IsNullOrEmpty(Descripcion)) { throw new DescripcionInvalidaException(); }
		}

		public void Update(Tema obj)
		{
			obj.Validar();
			Nombre = obj.Nombre;
			Descripcion = obj.Descripcion;
		}

	}
}
