// See https://aka.ms/new-console-template for more information

Console.WriteLine("INTERFACES");

//palabra reservada y definición:
//por convención las interfaces empiezan con I mayuscula.

interface IVehiculo
{
    void Arrancar();
    public string Marca { get; set; }
}
class Vehiculo : IVehiculo
{
    string IVehiculo.Marca { get; set; }
    void IVehiculo.Arrancar()
    {
        Console.WriteLine();
    }
}