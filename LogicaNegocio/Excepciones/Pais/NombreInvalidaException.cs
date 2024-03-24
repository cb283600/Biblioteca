namespace LogicaNegocio.Excepciones.Pais
{
	public class NombreInvalidaException : PaisException
	{
		public NombreInvalidaException() : base("El Nombre del pais debe ser valido") { }
		public NombreInvalidaException(string message) : base("El nombre del pais debe ser valido") { }
	}
}
