// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tema 10 - Clases y Objetos - LINQ");

//1. NUESTRO ORIGEN DE DATOS
int[] numbers = new int[] {1 , 2, 3, 4, 5, 6, 7, 8, 9, 10};
string[] names = new string[] {"Ana", "María", "Juan", "Pepe", "Daniel"};
//2. OBTENER DATOS (QUERY)
var pares =
    from number in numbers
    where (number % 2) == 0 //aca va la condición podria ser number > 5
    select number;
var impares =
    from number in numbers
    where (number % 2) != 0
    select number;
var nums =
    from number in numbers
    where (number > 5 && number <= 8)
    select number;
var nombres =
    from element in names
    where (element.Length > 3)
    select element;
//3.EJECUTAR CONSULTA

//Los atributos de los objetos anonimos son inmutables. 
var coche = new { Marca = "Ford", Año = 2021 };
Console.WriteLine("Tengo un coche marca "+coche.Marca+", del año "+coche.Año);



foreach (var num in pares)
{
    Console.Write(num);
}
Console.WriteLine("");
foreach (var num in impares)
{
    Console.Write(num);
}
Console.WriteLine("");
foreach (var num in nums)
{
    Console.Write(num);
}
Console.WriteLine("");
foreach (var element in nombres)
{
    Console.WriteLine(element);
}

void EscribirConsulta(string? str)
{
    Console.WriteLine("");
    foreach (var element in str)
    {
        Console.WriteLine(element);
    }
}
//C#