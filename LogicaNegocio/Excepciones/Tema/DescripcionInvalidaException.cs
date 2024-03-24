namespace LogicaNegocio.Excepciones.Tema
{
	public class DescripcionInvalidaException : TemaException
	{
		public DescripcionInvalidaException() : base("La descripcion debe ser valida") { }
		public DescripcionInvalidaException(string message) : base("La descripcion debe ser valida") { }
	}
}
