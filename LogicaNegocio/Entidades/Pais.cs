using LogicaNegocio.Excepciones.Pais;
using LogicaNegocio.IntefacesDominio;
using System.ComponentModel.DataAnnotations;

namespace LogicaNegocio.Entidades
{
	public class Pais : IValidable, IEntity
	{
		public int Id { get; set; }
		public string? Nombre { get; set; }
		public int CantHabitantes { get; set; }

		public Pais()
		{
		}

		public void Validar()
		{
			ValidarId();
			ValidarNombre();
			ValidarCantHabitantes();
		}

		private void ValidarId()
		{
			if (Id <= 0)
			{
				throw new IdInvalidaException();
			}
		}

		private void ValidarNombre()
		{
			if (string.IsNullOrEmpty(Nombre) || Nombre.Length <= 2)
			{
				throw new NombreInvalidaException();
			}
		}

		private void ValidarCantHabitantes()
		{
			if (CantHabitantes <= 0)
			{
				throw new CantHabitantesInvalidaException();
			}
		}

		public void Update(Pais obj)
		{
			obj.Validar();
			Nombre = obj.Nombre;
			CantHabitantes = obj.CantHabitantes;
		}
	}

}
