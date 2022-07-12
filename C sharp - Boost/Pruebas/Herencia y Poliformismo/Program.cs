// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Vehiculo miVehiculo = new Vehiculo();
miVehiculo.Arrancar();
Automovil miAutomovil = new Automovil();
miAutomovil.Arrancar();
miAutomovil.Arrancar("Alejandro");
miAutomovil.DetenerAutomovil();

//clase Padre
class Vehiculo
{
  public float combustible { get; set; }
  public int aforo { get; set; }

  public void Arrancar()
  {
    Console.WriteLine("Este Vehiculo ha arrancado");
  }
}
//clase child o hija
//Esta notación declara que Automovil hereda a vehiculo.
class Automovil : Vehiculo
{
  public int ruedas { get; set; }

  //en el caso que un método este repetido se ejecutara el metodo de la clase y no el heredado.
  public void Arrancar()
  {
    Console.WriteLine("Este auto ha arrancado");
  }

  public void Arrancar(string carOwner)
  {
    Console.WriteLine($"{carOwner} ha arrancado el automovil a las {DateTime.Now.ToShortTimeString()}.");
  }

  public void DetenerAutomovil()
  {
    Console.WriteLine("Este automovil se ha detenido");
  }
}