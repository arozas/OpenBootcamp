// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("CADENAS Y ARRAY");
//la distintas formas de iniciar un string:
string str;
string? str2 = null;
//puedo declarar al string como Empty, no es lo mismo que nulo.
string str3 = System.String.Empty;
//Esta forma de inicializar de nuevo, no es nulo, ni vacio, tiene valor:
string str4 = "";
string str5 = " ";
//Console.WriteLine(str); arroja error por que la cadena no esta inicializada
Console.WriteLine(str2); //al convertir el string a nullable puedo operarla, no muestra nada en consola por que es nula
Console.WriteLine(str3); //al estar vacio devuelve un output de system void, osea tiene valor y es vacio, por eso no es lo mismo que nulo.

//ARRAY DE CHARS Y STRINGS
char[] letters = {'a','b','c'};
Console.WriteLine(letters[0]);
string str6 = "abc";
Console.WriteLine(str6[0]);

//El string funciona como un array de chars, pero su función es la de escribir mensaje completos y facilitar la operación
// de estos mensajes, mientras que un array de char puede servir para identificar otras funciones, pero no es practico para
// escribir mensajes,

//CONCATENACIONES
string msg1 = "HOLA";
string msg2 = "soy Alejandro";
Console.WriteLine(msg1+msg2);
//otras formas de concatenar:
string msg3 = msg1+msg2;
Console.WriteLine(msg3);
string msg4 = msg1;
msg4 += msg2;
Console.WriteLine(msg4);

//LITERALES
// CARACTERES ESCAPADOS -> \n - SALTO DE LINEA
//                         \u00C6
//                         \r - SALTO DE FILA
//                         \T - TABULACIONES... (REVISAR LA DOC.)

//USOS :HACER COLUMNAS:
string columns = "COLUMNA 1\tCOLUMNA 2\tCOLUMNA 3";
string hr = "------------------------------------------------------- ";
string content = "CONTENIDO 1\tCONTENIDO 2\tCONTENIDO 3";
Console.WriteLine(columns);
Console.WriteLine(hr);
Console.WriteLine(content);
//MENSAJES MULTILINEA:
string multilinea1 = "HOLA"+
"ESTE ES UN MENSAJE"+
"MULTILINEA";
//el arroba antes del string, nos permite escribir mensajes multilinea sin cocatenar
string multilinea2 = @"HOLA
ESTE ES UN MENSAJE
MULTILINEA";

//METODOS OPTIMIZADOS, ES CASI SEGURO QUE FUNCIONEN MEJOR QUE LOS QUE PODAMOS DESARROLLAR NOSOTROS
//SUBCADENAS, SUBSTRING, REPLACE, INDEXOF
string miCadena = "este es un ejemplo   ";
string miCadena2 = miCadena.Substring(0,8);
Console.WriteLine(miCadena2);
string miCadena3 = miCadena.Replace("ejemplo","mensaje");
Console.WriteLine(miCadena3);
string miCadena4 = miCadena.Trim();
Console.WriteLine(miCadena4);
int indexCadena = miCadena.IndexOf('m');
Console.WriteLine("El indice donde esta la m es: "+ indexCadena);

//Strings nulos y vacíos.

using System.Text;

string str = "hello";
string? nullStr = null;
string emptyStr = String.Empty;
string tempStr = str+nullStr;
Console.WriteLine(tempStr);
bool b = (emptyStr==nullStr);
Console.WriteLine(b);

//Strings como objertos.
//Me permite crear tambien las cadenas como si creara un objeto con los metodos del StringBuilder.
StringBuilder StrBld = new StringBuilder("¡Hola Mundo!");
Console.WriteLine(StrBld);
var strBldCapacity = StrBld.Capacity;
Console.WriteLine(strBldCapacity);

//convertir Strings a Números.
int.TryParce
Float.TryaParce... etc


//ARRAYS Y SUS MÉTODOS
int[] arr = new int[2];
//Se pueden definir arrays de strings tambien:
string[] names = new string[2];
names[0] = "Jhon Doe";
names[1] = "Jhon Wick";
foreach (string elementos in names) //Esta es la forma más simple de hacerlo si queremos recorrer todo el arrayr.
{
    Console.WriteLine(elementos);
}

for (int i = 0; i < names.Length-1; i++) // Esta forma nos permite controlar hasta donde iterar.
{
    Console.WriteLine(names[i]);
}

int [] numbers = {4,3,8,0,5};
Array.Sort(numbers); //Con los metodos del array podemos operar de forma simple, como ordenar.
//revisar los metodos para ver todas las operaciones con arrays.
foreach (var elemento in numbers)
{
    Console.WriteLine(elemento);
}
*/
//MAS TIPOS DE ARRAYS
//ARRAYS PARALELOS
int[,] arrayParalelo = new int[2,2];
arrayParalelo[0,0] = 1;
arrayParalelo[0,1] = 2;
arrayParalelo[1,0] = 3;
arrayParalelo[1,1] = 4;

for (int k = 0; k < arrayParalelo.Length-2;k++)
{
    for (int l = 0; l < arrayParalelo.Length-2; l++)
    {
        Console.Write(arrayParalelo[k,l]); 
    }
}


