// See https://aka.ms/new-console-template for more information

//Prueba de tipos de datos.

Console.WriteLine("PRUEBAS DE TIPOS DE DATOS");

int i = 0;
float myFloat = i;
long l = 1;
float f = 1.5555f; 
//Se ingresa una f en la sintaxis para indentificar el float.
double myDouble = f; 
//No hay problema en la conversión por que el dato es más chico que la variable.
double d = 2.6666666666666d;
char c = 'c'; 
// Para un solo char hay que escribirlos en comillas simples, en comillas dobles es string.
string s = "string"; 
string myString = "32";
int myInt = Convert.ToInt32(myString); 
//esta convertido, el ToInt32, es la cantidad de bites.
Console.WriteLine("int: "+i); 
//la diferencia entre write y writeline es el salto de linea que incluye esta ultima.

const float pi = 3.1415;
// al ser una constante no se puede cambiar el valor de la variable, como por ejemplo sumar le uno.
// pi = pi+1; no va a compilar.


Console.WriteLine("myFloat: "+myFloat);
Console.WriteLine("MyString: "+myString);
myInt++;
Console.WriteLine("myInt: "+myInt);

Console.WriteLine("long: "+l);
Console.WriteLine("float: "+f);
Console.WriteLine("double: "+d);
Console.WriteLine("char: "+c);
Console.WriteLine("string: "+s);
*/

/*//Ejercicio.
Console.WriteLine("INGRESE SU NOMBRE:");
string nameInput = Console.ReadLine();
Console.WriteLine("INGRESE SU EDAD:");
int ageInput = Convert.ToInt32(Console.ReadLine()); 
//ReadLine espera un string, Read toma integers. Readline puede convertirse a Int
Console.WriteLine("INGRESE SU CIUDAD:");
String cityInput = Console.ReadLine();
Console.Write("Hola, "+nameInput);
Console.Write(". Tienes, "+ageInput);
Console.Write(". Vives en "+cityInput+".");
*/
