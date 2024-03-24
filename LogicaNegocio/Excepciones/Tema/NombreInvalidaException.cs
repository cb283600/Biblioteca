namespace LogicaNegocio.Excepciones.Tema
{
    public class NombreInvalidaException : TemaException
    {
        public NombreInvalidaException() : base("El Nombre debe ser valido") { }
        public NombreInvalidaException(string message) : base("El nombre no puede ser nulo y debe contener minimo 2 caracteres") { }
    }
}
