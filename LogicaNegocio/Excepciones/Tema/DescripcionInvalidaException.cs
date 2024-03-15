namespace LogicaNegocio.Excepciones.Tema
{
	public class DescripcionInvalidaException : TemaException
	{
		public DescripcionInvalidaException() { }
		public DescripcionInvalidaException(string message) : base("La descripcion debe ser valida") { }
	}
}
