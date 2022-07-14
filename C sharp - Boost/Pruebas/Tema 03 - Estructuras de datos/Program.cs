// See https://aka.ms/new-console-template for more information

Console.WriteLine("PRUEBAS DE ESTRUCTURAS");

//cada vea que se crea un objeto este debe ser inicializado, para eso tenemos el comando new.
//no puede en orden secuencial la declaración del objeto estar debajo de la clase.
//"Las instruciones de nivel superior deben preceder a las declaraciones de espacios de nombre y tipos"
Coords myCoords = new Coords(2,10,0); 

Console.WriteLine("Valor X: " + myCoords.X);
Console.WriteLine("Valor Y: " + myCoords.Y);
Console.WriteLine("Valor Z: " + myCoords.Z);

//estoy clonando la estructura (objeto) y declarando un nuevo valor a uno de sus atributos.
Coords myCoordsTwo = myCoords with { X  = 3 };
Console.WriteLine(myCoordsTwo);
public struct Coords
{
    public Coords (double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    //Si solo declaramos el get vamos solamente poder leer el valor
    // para modificar el valor debemos declarar los set también.
    public double X { get; set; } 
    public double Y { get; set; }
    public double Z { get; set; }
    
    public override string ToString() => $"({X},{Y}),{Z}";
}