// See https://aka.ms/new-console-template for more information

int menu;
do
{
    menu = PrintMenu("EJERCICIOS SESIÓN 5",
        "\n1 - EJERCICIO 1" +
        "\n2 - EJERCICIO 2." +
        "\n3 - SALIR.",
        "INGRESE UNA OPCIÓN <1-4>: ",
        "ERROR, INGRESE UNA OPCIÓN",
        3,
        3);
    switch (menu)
    {
        case 1:
            ExerciseOne();
            break;
        case 2:
            ExerciseTwo();
            break;
        default:
            Console.WriteLine("FINALIZÓ EL PROGRAMA");
            break;
        
    }
} while (menu != 3);

static int PrintMenu(string? title, String? menu, String? inputMsg,String? errorMsg , int? options, int retries) {
    int rtn = -1;
    if (title != null && menu != null && inputMsg != null && options > 0 && retries > 0) 
    {
        Console.WriteLine("\n"+title);
        Console.WriteLine(menu);
        string? optionInput;
        int optionInputInt;
        do {
            Console.WriteLine(inputMsg);
            optionInput = Console.ReadLine();
            if (string.IsNullOrEmpty(optionInput) 
                || !int.TryParse(optionInput, out optionInputInt) 
                || optionInputInt<1 
                || optionInputInt>options) 
            {
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

static bool Confirm(string question)
{
    bool rtn = false;
    ConsoleKeyInfo response;
    do
    {
        Console.WriteLine("\n"+question);
        Console.WriteLine("<S/N>:");
        response = Console.ReadKey();
        if (response.Key == ConsoleKey.S)
        {
            rtn = true;
            
        }
        else if (response.Key == ConsoleKey.N)
        {
            rtn = false;
        }
        else
        {
            Console.WriteLine("\nERROR, DEBE INGRESAR UNA RESPUESTA <S/N>");
        }
    } while (response.Key is not (ConsoleKey.S or ConsoleKey.N) );

    return rtn;
}

static void ExerciseOne()
{
    string? bufferName;
    string? bufferEmail;
    bool? bufferDiscount;
    Client? nuevoCliente = null;
    Console.WriteLine("\nEJERCICIO UNO.");
    Console.WriteLine("\nINGRESE LOS DATOS DEL CLIENTE.");
    Console.WriteLine("\nNOMBRE:.");
    bufferName = Console.ReadLine();
    if (string.IsNullOrEmpty(bufferName))
    {
        Console.WriteLine("\nERROR DEBE INGRESAR UN NOMBRE VALIDO.");
    }
    else
    {
        Console.WriteLine("\nEMAIL:.");
        bufferEmail = Console.ReadLine();
        if (string.IsNullOrEmpty(bufferEmail))
        {
            Console.WriteLine("\nERROR DEBE INGRESAR UN EMAIL VALIDO");
        }
        else
        {
            bufferDiscount = Confirm("¿TIENE CUPON DE DESCUENTO?");
            nuevoCliente = new Client(bufferName, bufferEmail, bufferDiscount);
            Console.WriteLine("\nESTE ES EL NUEVO CLIENTE:");
            Console.WriteLine(nuevoCliente);
        }
    }

    if (nuevoCliente != null)
    {
        float price;
        string? priceStr;
        Console.WriteLine("\nINGRESE EL VALOR DE LA COMPRA:");
        priceStr = Console.ReadLine();
        if (string.IsNullOrEmpty(priceStr)
            || !float.TryParse(priceStr, out price)
            || price < 1)
        {
            Console.WriteLine("\nERROR, DEBE INGRESAR UN VALOR VALIDO");
        }
        else
        {
            if (nuevoCliente.DiscountCoupon == true)
            {
                float discount;
                string? discountStr;
                Console.WriteLine("\nINGRESE EL DESCUENTO % :");
                discountStr = Console.ReadLine();
                if (string.IsNullOrEmpty(discountStr)
                    || !float.TryParse(discountStr, out discount)
                    || discount < 1)
                {
                    Console.WriteLine("\nERROR, DEBE INGRESAR UN DESCUENTO VALIDO");
                }
                else
                {
                    float calculatedDiscount = ((price * discount) / 100);
                    float finalPrice = price - calculatedDiscount;
                    Console.WriteLine("\nEL PRECIO A PAGAR CON DESCUENTO ES: $"+finalPrice);
                }
                
            }
            else
            {
                Console.WriteLine("El VALOR A PAGAR ES: $"+price);
            }
        }
    }
    else
    {
        Console.WriteLine("\nERROR, NO HAY CLIENTE PARA REALIZAR LA OPERACIÓN");
    }

}

static void ExerciseTwo()
{
    int menu;
    do
    {
        menu = PrintMenu("ELIJA UN LENGUAJE DE PROGRAMACIÓN",
            "\n1 - C" +
            "\n2 - C#" +
            "\n3 - JAVA."+
            "\n4 - JAVASCRIPT."+
            "\n5 - GO."+
            "\n6 - COBOL."+
            "\n7 - SALIR.",
            "INGRESE UNA OPCIÓN <1-7>: ",
            "ERROR, INGRESE UNA OPCIÓN",
            7,
            3);
        switch (menu)
        {
            case 1:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES C.");
                break;
            case 2:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES C#."+" ¡HOLA MUNDO!");
                break;
            case 3:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES JAVA");
                break;
            case 4:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES JAVASCRIPT");
                break;
            case 5:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES GO");
                break;
            case 6:
                Console.WriteLine("EL LENGUAJE ESCOGIDO ES COBOL");
                break;
            default:
                Console.WriteLine("FINALIZÓ EL PROGRAMA");
                break;
        }
    } while (menu != 7);
}

public class Client
{
    public Client(string? name, string? email, bool? discount)
    {
        Name = name;
        Email = email;
        DiscountCoupon = discount;
    }
    
    public string? Name { get; set; }
    
    public string? Email { get; set; }
    public bool? DiscountCoupon { get; set; }

    public override string ToString() => $"Nombre: {Name}, Email: {Email}, Descuento: {DiscountCoupon}";
}