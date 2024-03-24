namespace LogicaNegocio.Excepciones.Pais
{
	public class CantHabitantesInvalidaException : PaisException
	{
		public CantHabitantesInvalidaException() : base("La cantidad de habitantes debe ser valida") { }
		public CantHabitantesInvalidaException(string message) : base("La cantidad de habitantes debe ser valida") { }

	}
}
