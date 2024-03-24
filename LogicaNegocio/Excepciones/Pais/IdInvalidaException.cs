namespace LogicaNegocio.Excepciones.Pais
{
    public class IdInvalidaException : PaisException
    {

        public IdInvalidaException() : base("El ID es inválido.") { }

        public IdInvalidaException(string message) : base("El ID debe ser valido") { }

    }
}