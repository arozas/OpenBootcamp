// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
/*
//DECLARACIÓN DE LAS FUNCIONES
int CalcularCuadrado(int n)
{
    return n*n; //
}

//FUNCIONES ANONIMAS
int[] numbers ={2,3,4,5};
var squaredNumbers = numbers.Select(x => x*x);
Console.WriteLine(String.Join("",squaredNumbers));


//MÉTODOS. 

var miMoto = new Motos();
miMoto.Arrancar();
//SOBRECARGA DE METODOS.
var nivelDeposito = miMoto.CargarGasolina(4);
class Motos
{
    public void Arrancar()
    {
        Console.WriteLine("ARRANCA LA MOTO");
    }

    public int CantidadGasolina()
    {
        int gasolina = 20;
        return gasolina;
    }

    public int CargarGasolina(int litros)
    {
        int nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
    public float CargarGasolina(float litros)
    {
        float nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
    public double CargarGasolina(double litros)
    {
        double nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
}

//RECURSIVIDAD
//Es cuando una función se llama a si misma.

Console.WriteLine("Calcular factorial:"+CalcularFactorial(3));

long CalcularFactorial(int n)
{
    if (n == 1)
    {
        return 1; //cuando devolvemos 1 en este caso terminamos la recursividad.
    }
    return n * CalcularFactorial(n - 1);
}
*/
//OBJETOS

Puerta miPuerta = new Puerta();
miPuerta.CambiarAncho(200.20f);//cm
miPuerta.Abrir();
miPuerta.MostrarEstado();
miPuerta.Cerrar();
miPuerta.MostrarEstado(); 

//Declaración:
public class Puerta //nose puede pasar valores, para eso hay que inicializar los atributos
{
    //Declaramos atributos, sus caracterisiticas:
     float ancho;
     int alto;
     string? color;
     string? material;
     bool abierta = false; //se puede dar valores por defecto.
     
     //Constructor
   
     //Declaramos sus metodos, las acciones que realiza:
    public void CambiarAncho(int anchoPuerta)
    {
        ancho = anchoPuerta;
    }
    public void CambiarAncho(float anchoPuerta)
    {
        ancho = anchoPuerta;
    }

    public void pintarPuerta(string color)
    {
        //la palabra reservada "this" define que es el objeto de la clase donde esta declarada el objeto.
        this.color = color;
    }
    public void Abrir()
    {
        abierta = true;
        //en este caso emulamos el comportamiento de abrir y cerrar con un bool, abierta = false = cerrada.
    }

    public void Cerrar()
    {
        abierta = false;
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}",ancho);
        Console.WriteLine("Alto: {0}",alto);
        Console.WriteLine("Color: {0}",color);
        Console.WriteLine("Material: {0}",material);
        Console.WriteLine("¿Abierta?: {0}",abierta);
    }
}