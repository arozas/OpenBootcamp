import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        int menu;
        Scanner read = new Scanner(System.in);
        do {
            menu = printMenu("\nEJERCICIOS SETENCIAS DE CONTROL",
                    """
                            1 - CONDICIONAL IF
                            2 - BUCLES WHILE
                            3 - BUCLE DO WHILE
                            4 - BUCLE FOR
                            5 - SWITCH
                            6 - SALIR""",
                    "INGRESE UNA OPCIÓN <1-6>:",
                    "DEBE INGRESAR UNA OPCIÓN VALIDA <1-6>:",
                    6);
            switch (menu) {
                case 1:
                    System.out.println("INGRESE UN NÚMERO:");
                    int numeroIf = read.nextInt();
                    if(numeroIf < 0)
                    {
                        System.out.println("INGRESÓ EL NÚMERO:"+numeroIf);
                        System.out.println("El NÚMERO ES NEGATIVO");
                    } else if (numeroIf == 0) {
                        System.out.println("El NÚMERO ES CER0");
                    }
                    else
                    {
                        System.out.println("INGRESÓ EL NÚMERO:"+numeroIf);
                        System.out.println("El NÚMERO ES POSITIVO");
                    }
                    break;
                case 2:
                    int numeroWhile=0;
                    while(numeroWhile < 3)
                    {
                        numeroWhile++;
                        System.out.println("numeroWhile:"+numeroWhile);
                    }
                    break;
                case 3:
                    int numeroDo=0;
                    do
                    {
                        numeroDo++;
                        System.out.println("numeroDoWhile:"+numeroDo);
                    }while(numeroDo < 1);
                    break;
                case 4:
                    for (int numeroFor = 0; numeroFor <= 3; numeroFor++)
                    {
                        System.out.println("numeroFor:"+numeroFor);
                    }
                    break;
                case 5:
                    int estacion = printMenu("\nEJERCICIO SWITCH",
                            """
                                    1 - ENERO
                                    2 - FEBRERO
                                    3 - MARZO
                                    4 - ABRIL
                                    5 - MAYO
                                    6 - JUNIO
                                    7 - JULIO
                                    8 - AGOSTO
                                    9 - SEPTIEMBRE
                                    10 - OCTUBRE
                                    11 - NOVIEMRE
                                    12 - DICIEMBRE
                                    13 - SALIR""",
                            "SELECCIONE UN MES PARA QUE LE INFORME LA ESTACIÓN <1 - 13>:",
                            "DEBE INGRESAR UNA OPCIÓN VALIDA <1-13>:",
                            13);
                    switch (estacion) {
                        case 1, 2, 3 -> System.out.println("LA ESTACIÓN ES VERANO");
                        case 4, 5, 6 -> System.out.println("LA ESTACIÓN ES OTOÑO");
                        case 7, 8, 9 -> System.out.println("LA ESTACIÓN ES INVIERNO");
                        case 10, 11, 12 -> System.out.println("LA ESTACIÓN ES PRIMAVERA");
                        default -> System.out.println("NO ELIGIÓ UNA ESTACIÓN");
                    }
                    break;
                default:
                    System.out.println("FINALIZÓ EL PROGRAMA.");
            }
        }while(menu != 6);

    }
    public static int printMenu(String title, String menu, String inputMsg,String errorMsg , int options) {
        Scanner read = new Scanner(System.in);
        int rtn = -1;
        int optionInput;
        if (title != null && menu != null && inputMsg != null) {
            System.out.println(title);
            System.out.println(menu);
            do {
                System.out.println(inputMsg);
                optionInput = read.nextInt();
                if (optionInput < 1 || optionInput > options) {
                    System.out.println(errorMsg);
                }
                else
                {
                    rtn = optionInput;
                }
            } while (optionInput < 1 || optionInput > options);
        }
        return rtn;
    }
}