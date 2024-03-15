using Dominio.Excepciones;

namespace LogicaNegocio.Excepciones.Tema
{
	public class TemaException : DominioException
	{
		public TemaException() { }

		public TemaException(string message) : base(message) { }
	}
}