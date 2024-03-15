using LogicaNegocio.Excepciones.Pais;

namespace LogicaNegocio.Excepciones.Pais
{
	public class NombreInvalidaException : PaisException
	{
		public NombreInvalidaException() { }
		public NombreInvalidaException(string message) : base("El nombre del pais debe ser valido") { }
	}
}
