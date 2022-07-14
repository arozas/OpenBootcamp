// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine("Tema 12 - Collections");
/*
//Colección de Strings
var coches = new List<string>();
coches.Add("Ford");
coches.Add("BMW");
coches.Add("Peugeot");

var coches2 = new List<string> {"Seat", "VolksWagen", "Fiat" };

foreach (var element in coches)
{
    Console.Write(element + " ");
}


List<Elemento> elemento = CrearLista();

var query = from el in elemento
    where el.NumeroAtomico > 20
    select el;
foreach (Elemento el in query)
{   
    Console.WriteLine($"Nombre: {el.Nombre}, Simbolo: {el.Simbolo}, Numero Atómico: {el.NumeroAtomico}");
}

// Colecction Generica: 
static List<Elemento> CrearLista()
{
    return new List<Elemento>
    {
        { new Elemento() { Simbolo = "K", Nombre = "Potasio", NumeroAtomico = 19 } },
        { new Elemento() { Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 20 } },
        { new Elemento() { Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22 } }
    };
}

public class Elemento
{
    public string? Simbolo { get; set; }
    public string? Nombre { get; set; }
    public int NumeroAtomico { get; set; }
}


//SORT

ListaCoches();

 static void ListaCoches()
{
    var cars = new List<Car>
    {
        
        { new Car() { Name = "car5", Color = "blue", Speed = 30 } },
        { new Car() { Name = "car6", Color = "red", Speed = 60 } },
        { new Car() { Name = "car7", Color = "green", Speed = 50 } },
        { new Car() { Name = "car1", Color = "blue", Speed = 20 } },
        { new Car() { Name = "car2", Color = "red", Speed = 50 } },
        { new Car() { Name = "car3", Color = "green", Speed = 10 } },
        { new Car() { Name = "car4", Color = "blue", Speed = 50 } }
    };
    cars.Sort();
    foreach (Car coche in cars)
    {
        Console.WriteLine($"{coche.Color}, {coche.Name}, {coche.Speed}");
    }
}

public class Car:IComparable<Car>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }

    public int CompareTo(Car? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var colorComparison = string.Compare(Color, other.Color, StringComparison.Ordinal);
        if (colorComparison != 0) return colorComparison;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return Speed.CompareTo(other.Speed);
    }
}
*/
//COLLECTION PERSONALIZADA

//Clase de colección personalizada declaración con enumerador personalizdo:

var colors = new MisColores();

foreach (Colores el in colors)
{
    Console.WriteLine($"Nombre del Color {el.Nombre}, Codigo: {el.CodigoHex}");
}


public class MisColores : IEnumerable
{
    private Colores[] _colors =
    {
        new Colores() {Nombre = "Rojo", CodigoHex = 0000},
        new Colores() {Nombre = "Azul", CodigoHex = 1111},
        new Colores() {Nombre = "Verde", CodigoHex = 3333}
    };
        
    public IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(_colors);
    }

    private class ColorEnumerator : IEnumerator
    {
        private Colores[] _colors;
        private int _position = -1;

        public ColorEnumerator(Colores[] colors)
        {
            _colors = colors;
        }

        Object IEnumerator.Current
        {
            get { return _colors[_position]; }
        }
        bool IEnumerator.MoveNext()
        {
            _position++;
            return (_position < _colors.Length);
        }

        void IEnumerator.Reset()
        {
            _position = -1;
        }
    }
}

public class Colores
{
    public string? Nombre { get; set; }
    public int CodigoHex { get; set; }
}
