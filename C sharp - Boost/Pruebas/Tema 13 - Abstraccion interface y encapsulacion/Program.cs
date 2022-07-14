// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
/*
var persona = new Person();
persona.setData();
persona.printData();

public class Person : IPersons
{


    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly? Birthday { get; set; }
    public int Age { get; set; }
    public bool Working { get; set; }


    public Person(string name, string surname, int age, bool ocupado, DateOnly birthday)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Working = ocupado;
        Birthday = birthday;
    }

    public Person()
    {
        Name = null;
        Surname = null;
        Age = 0;
        Working = false;
        Birthday = null;
    }

    public void setData()
    {
        string? nombre = null;
        do
        {
            Console.WriteLine("INGRESE SU NOMBRE:");
            nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("ERROR DEBE INGRESAR UN NOMBRE VALIDO");
            }
            else
            {
                Name = nombre;
            }
        } while (string.IsNullOrEmpty(nombre));

        string? apellido = null;
        do
        {
            Console.WriteLine("INGRESE SU APELLIDO:");
            apellido = Console.ReadLine();
            if (string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("ERROR DEBE INGRESAR UN APELLIDO VALIDO");
            }
            else
            {
                Surname = apellido;
            }
        } while (string.IsNullOrEmpty(apellido));

        string? fechaNacimiento = null;
        DateOnly fechaNacimiento2;
        do
        {
            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO:");
            fechaNacimiento = Console.ReadLine();
            if (string.IsNullOrEmpty(fechaNacimiento) || !DateOnly.TryParse(fechaNacimiento, out fechaNacimiento2))
            {
                Console.WriteLine("ERROR DEBE INGRESAR UNA FECHA VALIDA");
            }
            else
            {
                Birthday = fechaNacimiento2;
            }
        } while (string.IsNullOrEmpty(fechaNacimiento) || !DateOnly.TryParse(fechaNacimiento, out fechaNacimiento2));
    }
    public void printData()
    {
        Console.WriteLine($"Nombre: {Name}, Apellido: {Surname}, Fecha de nacimiento: {Birthday}, Edad: {Age}, Ocupado: {Working} ");
    }


}

public interface IPersons
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateOnly? Birthday { get; set; }
    public int Age { get; set; }
    public bool Working { get; set; }
    

    public void setData();
}

//ENUMS

Console.WriteLine(Estaciones.Verano); // imprime el valor
Console.WriteLine((int)Estaciones.Verano); //muestra la posición en lista
Console.WriteLine(CodigosDeError.Desconocido);
Console.WriteLine((int)CodigosDeError.Desconocido);

enum Estaciones
{
    Verano,
    Otoño,
    Invierno,
    Primavera
}

enum CodigosDeError : ushort
{
    Ninguno = 0,
    Desconocido = 1,
    SinConexión = 100,
    Conexión = 200
}
*/
//TUPLAS (tuples)

(string, double, int) miTupla = ("Cesar", 1.1d, 9);
Console.WriteLine(miTupla);
Console.WriteLine($"Item1: {miTupla.Item1}, Item2: {miTupla.Item2}, Item3: {miTupla.Item3}");
int miSuma = 10 + 20;
Double cociente = 5/30d;
(int Suma, double Division) otraTupla = (miSuma, cociente);
Console.WriteLine($"Item1: {otraTupla.Item1}, Item2: {otraTupla.Item2}");