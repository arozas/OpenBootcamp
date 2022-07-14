// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

Puerta miPuerta = new Puerta(150, 250, "Natural");
miPuerta.MostrarEstado();

public class Puerta
{
    
    float ancho;
    float alto;
    string? color;
    string? material;
    private bool abierta;

    //CONSTRUCTOR Es un metodo particular, que tiene el mismo nombre que la clase, este puede recibir parametros o no.
    //nosotros podemos definir valores por defecto o pasarlos por parametros.
    public Puerta(float ancho = 100, float alto = 200, string color = "Sin Color", string material = "Madera", bool abierta =false)
    { //Se definen parametros por defecto en los parametros para la clase, y de esta forma al crearlo no es necesario inicializar todo.
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.material = material;
        this.abierta = abierta;
    }
    public void MostrarEstado()
    {
        Console.WriteLine("Ancho:\t\t{0}",ancho);
        Console.WriteLine("Alto:\t\t{0}",alto);
        Console.WriteLine("Color:\t\t{0}",color);
        Console.WriteLine("Material:\t{0}",material);
        Console.WriteLine("¿Abierta?:\t{0}",abierta);
    }
    //DESTRUCTOR
    ~Puerta()
    {
        //CÓDIGO QUE SE EJECUTA CUANDO SE DESTRUYE UNA PUERTA
        Console.WriteLine("La puerta se ha destruido");
    }
}
*/

Person student = new Person();
student.Name = "Pedro";
student.Birthday = Convert.ToDateTime("18/08/1985");
student.Registrar();

/*
 // Clase PErsona con Encapsulamiento abierto
public class Person
{
    //Atributos
    public string name;
    public DateTime birthday;
    private int age;

    public void registrar()
    {
        calcularEdad(birthday);
        Console.WriteLine(name + " con " + age + " años de edad ha sido registrado correctamente");
    }

    private void calcularEdad(DateTime personBirthday)
    {
        DateTime actualDate = DateTime.Now;
        age = actualDate.Year - personBirthday.Year;
    }
}
*/
//Clase persona encapsulamiento cerrado
public class Person
{
    //Atributos
    private string? _name;
    private DateTime _birthday;
    private int _age;

    public int Age
    {
        get //Encapsulación nivel abierto, por defecto es publico por que la propiedad es público.
        {
            return _age;
        }
        private set //nivel de Encapsulación cerrado - privado. Solo se puede usar desde la clase
        {
            _age = value;
        }
    }
    public DateTime Birthday
    {
        get
        {
            return _birthday;
        }
        set
        {
            _birthday = value;
        }
    }
    public string? Name
    {
        get //Devuelve el valo que contiene el objeto
        {
            return _name;
        }
        set //Setea el valor en el objeto
        {
            _name = value;
        }
    }

    public void Registrar()
    {
        CalcularEdad(_birthday);
        Console.WriteLine(_name + " con " + _age + " años de edad ha sido registrado correctamente");
    }

    private void CalcularEdad(DateTime personBirthday)
    {
        DateTime actualDate = DateTime.Now;
        _age = actualDate.Year - personBirthday.Year;
    }
}