public class Main {
    public static void main(String[] args)
    {
        coche miCoche = new coche();
        miCoche.addPuertas();
        System.out.println("Puertas del Coche:");
        System.out.println(miCoche.puertas);
    }
}
class coche
{
    int puertas;

    public void addPuertas ()
    {
        puertas++;
    }

}