// See https://aka.ms/new-console-template for more information

Console.WriteLine("Pruebas de Bucles");

// FOREACH - PARA/POR CADA
// podriamos decir que el objeto es tipo List, pero usamos var para que sea más corto para el ejemplo de uso del foreach
// nombre del objeto "myList"
// usamos la palabra reservada new que crea un nuevo objeto "List" y el tipo datos que queremos guardar es "string"
var myList = new List<string> {"Alejandro", "Alberto", "Martin","Celeste"};

Console.WriteLine("FOREACH");
foreach (var element in myList)
{
    Console.WriteLine(element);
}

int i = 0;
int suma = 0;
for (i=0; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("La Suma del for es: " + suma);//5050

//expandir el código para que el usuario indique hasta cuando se hace la suma.

/*
int j = 0;
int resultado = 0;
int limite = 0;
Console.WriteLine("INTRODUCE EL LIMITE DE LA SUMA:");
limite = Convert.ToInt32(Console.ReadLine());
for (j=0; j <= limite; j++)
{
    resultado += j;
}
//El simbolo de dolar al principio del string nos permite interpolar el valor de la variable dentro del string, para no concatenar.
Console.WriteLine($"El resultado del for es: {resultado}");
*/
//Escibir todos los elementos de un array.
//asi se define un array de 3 elementos:
Console.WriteLine("ITERO ARRAY CON FOR");
int[] arr = new int[4];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
arr[3] = 4;
for(i=0; i<3; i++)
{
    Console.Write($",{arr[i]}");
}
//El foreach nos evita hardcodear valores estaticos que no se adaptan a lo que necesitamos.
Console.WriteLine("\nITERO ARRAY CON FOREACH");
foreach (var item in arr)
{
    Console.Write($",{item}");
}
Console.WriteLine("\nITERO ARRAY CON WHILE");
i = 0;
while (i < 3)
{
    Console.Write($",{arr[i]}");
    i++;
}