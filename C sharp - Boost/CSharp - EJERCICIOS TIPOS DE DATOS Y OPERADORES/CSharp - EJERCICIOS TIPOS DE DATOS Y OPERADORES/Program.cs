// See https://aka.ms/new-console-template for more information

Console.WriteLine("EJERCICIOS DE C# - SESIÓN DOS!");
int options;
do
{
    options = PrintMenu("EJERCICIOS", 
        "\n1 - EJERCICIO 1" +
        "\n2 - EJERCICIO 2." + 
        "\n3 - EJERCICIO 3." + 
        "\n4 - SALIR.", 
        "INGRESE UNA OPCIÓN <1-4>: ", 
        "ERROR, INGRESE UNA OPCIÓN",
        4,
        3);
    switch (options)
    {
        case 1:
            ExerciseOne();
            break;
        case 2:
            ExerciseTwo();
            break;
        case 3:
            ExerciseThree();
            break;
        default:
            Console.WriteLine("FINALIZÓ EL PROGRAMA");
            break;
    }   
} while (options!=4);

static int PrintMenu(string? title, String? menu, String? inputMsg,String? errorMsg , int? options, int retries) {
    int rtn = -1;
    if (title != null && menu != null && inputMsg != null && options > 0) {
        Console.WriteLine(title);
        Console.WriteLine(menu);
        string? optionInput;
        int optionInputInt;
        do {
            Console.WriteLine(inputMsg);
            optionInput = Console.ReadLine();
            if (string.IsNullOrEmpty(optionInput) 
                || !int.TryParse(optionInput, out optionInputInt) 
                || optionInputInt<1 
                || optionInputInt>options) {
                Console.WriteLine(errorMsg);
            }
            else
            {
                rtn = optionInputInt;
            }
            retries--;
        } while ((string.IsNullOrEmpty(optionInput) 
                  || !int.TryParse(optionInput, out optionInputInt) 
                  && (optionInputInt<1 || optionInputInt>options))
                 && retries > 0 );
    }
    if(rtn==-1)
    {
        Console.WriteLine("ERROR, AGOTÓ LOS INTENTOS");
    }
    return rtn;
}

static void ExerciseOne()
{
    Console.WriteLine("INGRESE SU DATOS");
    string? nameInput;
    string? surnameInput;
    string? ageInput;
    int ageInputInt;
    string? cityInput;
    do
    {
        Console.WriteLine("¿SU NOMBRE?:");
        nameInput = Console.ReadLine();
        if (string.IsNullOrEmpty(nameInput))
        {
            Console.WriteLine("SU NOMBRE NO PUEDE QUEDAR VACIO, INTENTELO DE NUEVO.");
        }
    } while (string.IsNullOrEmpty(nameInput));
    do
    {
        Console.WriteLine("¿SU APELLIDO?:");
        surnameInput = Console.ReadLine();
        if (string.IsNullOrEmpty(surnameInput))
        {
            Console.WriteLine("SU APELLIDO NO PUEDE QUEDAR VACIO, INTENTELO DE NUEVO.");
        }
    }while(string.IsNullOrEmpty(surnameInput));

    do
    {
        Console.WriteLine("¿SU EDAD?:");
        ageInput = Console.ReadLine();
    } while (string.IsNullOrEmpty(ageInput)
             && !int.TryParse(ageInput, out ageInputInt)
             && ageInputInt is < 0 or > 200);
    
    Console.WriteLine("¿EN QUE CIUDAD VIVE?:");
    cityInput = Console.ReadLine();
    Console.WriteLine("LOS DATOS INGRESADOS");
    Console.WriteLine("Usted se llama "
                      +nameInput
                      +" "
                      +surnameInput
                      +"."
                      +"\nTiene "
                      +ageInput
                      +" y vive en "
                      +cityInput+".");
}

static void ExerciseTwo()
{
    Cars coche = new Cars("Ka", "FORD", 2019,4,4,0);
    Table mesa = new Table(5.5f, 4.5f, 4.4f, "Madera", "Caoba");
    coche.PrintCar();
    mesa.PrintTable();
}

static void ExerciseThree()
{
    string? inputIntStr;
    string? inputCharStr;
    int inputInt;
    char inputChar;
    do
    {
        Console.WriteLine("INGRESE UN NUMERO:");
        inputIntStr = Console.ReadLine();
        if (string.IsNullOrEmpty(inputIntStr) || !int.TryParse(inputIntStr, out inputInt))
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO");
        }
    } while (string.IsNullOrEmpty(inputIntStr) || !int.TryParse(inputIntStr, out inputInt));

    do
    {
        Console.WriteLine("INGRESE UNA LETRA:");
        inputCharStr = Console.ReadLine();
        if (string.IsNullOrEmpty(inputCharStr) || !char.TryParse(inputCharStr, out inputChar) || !char.IsLetter(inputChar))
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UNA LETRA");
        }
    } while (string.IsNullOrEmpty(inputCharStr) || !char.TryParse(inputCharStr, out inputChar) || !char.IsLetter(inputChar));

    if (inputInt == 18 && inputChar == 'a')
    {
        Console.WriteLine("AMBAS CONDICIONES SON VERDADERAS");
    }
    else
    {
        if (inputInt == 18 && inputChar != 'a')
        {
            Console.WriteLine("SOLO LA CONDICIÓN NUMERICA ES VERDADERA");
        }
        else
        {
            if (inputInt != 18 && inputChar == 'a')
            {
                Console.WriteLine("SOLO LA CONDICIÓN CHAR ES VERDADERA");
            }
            else
            {
                {
                    Console.WriteLine("AMBAS CONDICIONES SON FALSAS");
                }
            }
        }
    }

}

public class Cars
{
    private string _name;
    private string _company;
    private int _manufactureYear;
    private int _doors;
    private int _wheels;
    private float _kilometers;
    private bool _new;

    public Cars(string name, string company, int manufactureYear, int doors, int wheels, float kilometers)
    {
        _name = name;
        _company = company;
        _manufactureYear = manufactureYear;
        _doors = doors;
        _wheels = wheels;
        _kilometers = kilometers;
        if(_kilometers > 0)
        {
            _new = false;
        }
        else
        {
            _new = true;
        }
    }
    public void PrintCar()
    {
        Console.WriteLine("AUTO:");
        Console.WriteLine("MODELO: " + _name);
        Console.WriteLine("MARCA: " + _company);
        Console.WriteLine("AÑO DE FABRICACIÓN: " + _manufactureYear);
        Console.WriteLine("PUERTAS: " + _doors);
        Console.WriteLine("RUEDAS: " + _wheels);
        Console.WriteLine("KILOMETROS: " + _kilometers);
        Console.WriteLine("0km: " + _new);
    }
}

public class Table
{
    private float _weight;
    private float _width;
    private float _lenght;
    private string _material;
    private string _color;

    public Table(float weight, float width, float lenght, string material, string color)
    {
        _weight = weight;
        _width = width;
        _lenght = lenght;
        _material = material;
        _color = color;
    }

    public void PrintTable()
    {
        Console.WriteLine("MESA:");
        Console.WriteLine("PESO: " + _weight);
        Console.WriteLine("ANCHO: " + _width);
        Console.WriteLine("LARGO: " + _lenght);
        Console.WriteLine("MATERIAL: " + _material);
        Console.WriteLine("COLOR: " + _color);
     
    }
}
