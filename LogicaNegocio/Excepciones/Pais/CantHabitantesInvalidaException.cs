using LogicaNegocio.Excepciones.Pais;

namespace LogicaNegocio.Excepciones.Pais
{
	public class CantHabitantesInvalidaException : PaisException
	{
		public CantHabitantesInvalidaException() { }
		public CantHabitantesInvalidaException(string message) : base("La cantidad de habitantes debe ser valida") { }

	}
}
