
public class UsuarioNoEncontrado : Exception
{
    //Cuando creamos nuestras propias excepciones debemos deribarlas de la excepciones madres.
    public UsuarioNoEncontrado()
    {
        Console.WriteLine("Ese usuario no existe");
    }

    public UsuarioNoEncontrado(string message) : base(message)
    {
    }
    public UsuarioNoEncontrado(string message, Exception ex) : base(message, ex)
    {
        //implementamos la logica para la excepcion.
    }
}