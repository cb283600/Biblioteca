using LogicaNegocio.Excepciones.Tema;

namespace LogicaNegocio.Excepciones.Tema
{
	public class DescriptionInvalidaException : TemaException
	{
		public DescriptionInvalidaException() { }
		public DescriptionInvalidaException(string message) : base("La descripcion debe ser valida") { }
	}
}
