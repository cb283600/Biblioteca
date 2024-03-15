using Dominio.Excepciones;

namespace LogicaNegocio.Excepciones.Pais
{
	public class PaisException : DominioException
	{
		public PaisException() { }

		public PaisException(string message) : base(message) { }
	}
}