using LogicaNegocio.Excepciones.Tema;

namespace Dominio.Excepciones.Tema
{
	public class IdInvalidaException : TemaException
	{
		public IdInvalidaException() { }
		public IdInvalidaException(string message) : base("El ID debe ser valido") { }

	}
}