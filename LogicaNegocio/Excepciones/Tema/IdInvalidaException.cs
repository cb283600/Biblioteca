namespace LogicaNegocio.Excepciones.Tema
{
    public class IdInvalidaException : TemaException
    {
        public IdInvalidaException() : base("El ID debe ser valido") { }
        public IdInvalidaException(string message) : base("El ID debe ser valido") { }

    }
}