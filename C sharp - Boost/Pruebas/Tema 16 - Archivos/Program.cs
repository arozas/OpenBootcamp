// See https://aka.ms/new-console-template for more information

//using System.IO;

Console.WriteLine("ARCHIVOS");

//Crear archivos TXT y realizar operaciones.

string texto;
//LEER UN ARCHIVO DESDE LA CARPETA DEL PROYECTO:
/*
//Intentar/Capturar
//Intenta una acción, y en el caso  que falle "captura" un error.
//Va intentar ejecutar un código, y en caso que falle, "captura" el error para que no frene el programa.
try
{
//Ahora se crea un objeto que va a guardar la información del archivo a leer.
//StreamReader es un objeto que lee  caracteres de un flujo en una códificación particular
//HAY QUE TENER CUIDADO SIEMPRE CON LA CODIFICACIÓN (Si no le decimos al programa lea el archivo con la códificación correcta
// no se va a traducir bien el archivo, y podemos guardar en el programa "basura".

    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine(); //ReadLine lee una linea de caracteres del archivo actual.
    //condición while: hasta finalizar el documento
    while (linea != null) //hasta que la lectura de la linea sea "null", osea no haya más texto.
    {
        // repetimos acciones
        Console.WriteLine(linea); //en este caso imprimos el texto en consola.
        linea = sr.ReadLine();
    }

    sr.Close(); //Cerramos el espacio de memoria abierto para leer el archivo.(stream asociado al archivo)
    Console.ReadKey(); // en este caso usamos el comando este para que no cierre el programa hasta que precionemos una tecla
}
//objeto Excepcion: representa errores ocurrido durante la ejecución del programa.
// se puede ver la fuente del error, como su trasa.
catch (Exception ex)
{
    //error, (Exception = representa errores que suceden durante la ejecución del programa)
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
finally
{
    //En caso de error podemos hacer una acción última con finally.
    Console.WriteLine("Final del try-catch-finally");
}

//ESCRIBIR EN UN ARCHIVO TXT:

try
{
    StreamWriter sw = new StreamWriter("miArchivo.txt");
    sw.WriteLine("Estoy escribiendo en mi archivo"); //Con esta operacion estamos escribiendo encima de lo que estaba.
    sw.WriteLine("otra linea");
    sw.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
    throw;
}
try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close();
    Console.ReadKey();
}

catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
finally
{
    Console.WriteLine("Final del try-catch-finally");
}

OPERACIONES CON ARCHIVOS:
 - Crear archivo.
 - Leer  -> no modifica el contenido. //abrimos en modo lectura
 - Escribir -> si modifica y borra lo anterior. //abrimos en modo escritura.
 - Append (añadir) -> Escribe añadiendo contenido al final // abrimos en modo "append" (añadir) (no borra lo anterior)
 */

//APERTURA DEL ARCHIVO EN MODO APPEND (Este es el modo más usado ya que siempre queremos agregar información)
try
{
    //El constructor del objeto, tiene un bool, para habilitar el modo "append", por eso añadimos el true.
    StreamWriter sw = new StreamWriter("miArchivo.txt", true); 
    sw.WriteLine("Añado esta linea");
    sw.WriteLine("Añado esta otra linea");
    sw.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
    throw;
}
try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close();
    Console.ReadKey();
}

catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
finally
{
    Console.WriteLine("Final del try-catch-finally");
}