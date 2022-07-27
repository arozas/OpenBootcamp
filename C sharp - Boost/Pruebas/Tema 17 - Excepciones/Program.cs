// See https://aka.ms/new-console-template for more information


Console.WriteLine("Excepciones");
//Gestion y manejo de errores,.

Console.WriteLine($"1 entre 2 es: {DivisionSegura(1,2)}");
try
{
    Console.WriteLine($"1 entre 0 es: {DivisionSegura(1, 0)}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERR: el siguiente error: {ex.Message}");
}
//Si con el manejo de excepciones, gestionamos el error, el programa puede continuar:
Console.WriteLine($"1 entre 3 es: {DivisionSegura(1,3)}");
int[] arr = new int[3];
arr[0] = 0;
arr[1] = 1;
arr[2] = 2;

try
{
    Console.WriteLine(arr[3]);
}
catch (Exception ex)
{
    Console.WriteLine($"ERR: el siguiente error: {ex.Message}");
}
finally
{
    Console.WriteLine("Es correcto el valor que aparece?");
}

Console.WriteLine("Fin del programa");


static double DivisionSegura(double a, double b)
{
    if (b == 0)
    {
        throw new UsuarioNoEncontrado();
    }
    return a / b;
}
/*Tipos
 * Exceptions -> clase base de las excepciones
 * IndexOutOfRangeException -> Se intentó pedir un elemento que no existe en un array, etc.
 * NullReference Exception -> Se pidió un objeto null.
 * ArgumentException -> Clase base para excepciones relacionadas con argumentos de los metodos o funciones.
 * ArgumentNullException ->
 * ArgumentOutRangeException ->
 */