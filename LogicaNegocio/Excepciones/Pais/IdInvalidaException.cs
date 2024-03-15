using LogicaNegocio.Excepciones.Pais;

namespace LogicaNegocio.Excepciones.Pais
{
	public class IdInvalidaException : PaisException
	{
		public IdInvalidaException() { }
		public IdInvalidaException(string message) : base("El ID debe ser valido") { }

	}
}