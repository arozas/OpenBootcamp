// See https://aka.ms/new-console-template for more information

int menu;
do
{
    menu = PrintMenu("EJERCICIOS SESIÓN 4",
        "\n1 - EJERCICIO 1" +
        "\n2 - EJERCICIO 2." +
        "\n3 - EJERCICIO 3." +
        "\n4 - SALIR.",
        "INGRESE UNA OPCIÓN <1-4>: ",
        "ERROR, INGRESE UNA OPCIÓN",
        4,
        3);
    switch (menu)
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
} while (menu != 4);

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
    int i = 0;
    int numberInput;
    string? numberInputStr;
    do
    {
        Console.WriteLine("PARA VER LA TABLA DE MULTIPLICACIÓN INGRESE UN NÚMERO:");
        numberInputStr = Console.ReadLine();
        //valido que no sea null ni que este vacio y que sea un numero. (Esta validación se puede abstrer del código)
        if (string.IsNullOrEmpty(numberInputStr)
            || !int.TryParse(numberInputStr, out numberInput))
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO");
        }
        else
        {
            Console.WriteLine($"TABLA DE MULTIPLICACIÓN DEL {numberInputStr}");
            while (i < 10)
            {
                i++;
                Console.WriteLine($"{numberInput}X{i} = {numberInput * i}");
            }
        }
        //itero hasta que numero ingresadp no sea null ni que este vacio y que sea un numero.
    } while (string.IsNullOrEmpty(numberInputStr)
             || !int.TryParse(numberInputStr, out numberInput));
}

static void ExerciseTwo()
{
    int numberInput;
    int[] i = {0,0};
        string? numberInputStr;
    do
    {
        Console.WriteLine("\nINGRESE UN NUMERO PARA VERIFICAR SI ES POSITIVO O NEGATIVO:");
        numberInputStr = Console.ReadLine();
        //valido que no sea null ni que este vacio y que sea un numero. (Esta validación se puede abstrer del código)
        if (string.IsNullOrEmpty(numberInputStr)
            || !int.TryParse(numberInputStr, out numberInput))
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO");
        }
        else
        {
            if (numberInput < 0)
            {
                Console.WriteLine("EL NUMERO INGRESADO ES NEGATIVO.");
                i[0]++;
            }
            else
            {
                Console.WriteLine("EL NUMERO INGRESADO ES POSITIVO.");
                i[1]++;
            }
        }
    } while (Confirm("¿DESEA CONTINUAR VERIFICANDO NUMEROS?"));
    Console.WriteLine("\nLA CANTIDAD DE NUMEROS NEGATIVOS INGRESADOS ES: "+i[0]);
    Console.WriteLine("LA CANTIDAD DE NUMEROS POSTIVOS INGRESADOS ES: "+i[1]);
} 
static void ExerciseThree()
{
    int squareAmount=0;
    string? squareAmountStr;
    int squareWidth=0;
    string? squareWidthStr;
    int squareLength=0;
    string? squareLengthStr;
   
        Console.WriteLine("\nINGRESE LA CANTIDAD DE CUADRADOS:");
        squareAmountStr = Console.ReadLine();
        //valido que no sea null ni que este vacio y que sea un numero. (Esta validación se puede abstrer del código)
        if (string.IsNullOrEmpty(squareAmountStr)
            || !int.TryParse(squareAmountStr, out squareAmount) || squareAmount < 0)
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO QUE SEA POSITIVO");
        }
        Console.WriteLine("\nINGRESE EL ANCHO DEL CUADRADO:");
        squareWidthStr = Console.ReadLine();
        //valido que no sea null ni que este vacio y que sea un numero. (Esta validación se puede abstrer del código)
        if (string.IsNullOrEmpty(squareWidthStr)
            || !int.TryParse(squareWidthStr, out squareWidth) || squareWidth < 0 )
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO QUE SEA POSITIVO");
        }
        Console.WriteLine("\nINGRESE EL LARGO DEL CUADRADO:");
        squareLengthStr = Console.ReadLine();
        //valido que no sea null ni que este vacio y que sea un numero. (Esta validación se puede abstrer del código)
        if (string.IsNullOrEmpty(squareLengthStr)
            || !int.TryParse(squareLengthStr, out squareLength) || squareLength < 0 )
        {
            Console.WriteLine("ERROR, DEBE INGRESAR UN NUMERO QUE SEA POSITIVO");
        }

        if (Confirm("¿DESEA QUE EL CUADRADO TENGA RELLENO?"))
        {
            Console.WriteLine(" ");
            do
            {
                string linea = " ";
                for (int i = 1; i <= squareWidth; i++)
                {
                    linea += "* ";
                }

                for (int j = 1; j <= squareLength; j++)
                {
                    Console.WriteLine(linea);
                }
                Console.WriteLine("\n");
                squareAmount--;
            } while (squareAmount > 0);
        }
        else
        {
            Console.WriteLine(" ");
            var Asteriscos = new string('*', squareWidth);
            for (int k = 0; k < squareAmount; k++)
            {
                for (int i = 0; i < squareLength; i++)
                {
                    // Imprimimos asteriscos como sea necesario.
                    if (i == 0 || i == (squareLength - 1))
                        Console.WriteLine(Asteriscos);
                    else
                        Console.WriteLine("*{0," + (squareWidth - 2) + "}*", ' ');
                }
            }
        }
}


   
   
