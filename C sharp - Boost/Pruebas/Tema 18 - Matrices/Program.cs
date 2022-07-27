// See https://aka.ms/new-console-template for more information

Console.WriteLine("MATRICES");
/*MATRICES
 *m = (1,2)
 *    (3,4)

//Formas de declar un vector o array unidemencional:

//Estamos declarando un array conociendo el número de elementos: 
//para esta declaración debemos saber el numero de elementos.
//no es necesario conocer el elemento en especifico, ya que se puede declarar después.
 int[] array = new int[2];
 array[0] = 1;
 array[1] = 2;

//Estamos declarando y fijando los valores del array:
int[] array2 = new int[] {1,2,3,4};
int[] array3 = {1,2,3};

Console.WriteLine(array2.Average());

Console.Write("Array = ( ");
for (int i = 0; i < array3.Length; i++)
{
 array3[i] += 1;
}
foreach (int el in array3)
{
 Console.Write(el+" ");
}
Console.Write(")\n");

//NO PODEMOS ESCRIBIR EL ARRAY DE FORMA VECTOR SIN EMPLEAR ALGUN ALGORITMO QUE LO HAGA, COMO ES EL CASO ANTERIOR.
Console.WriteLine(array.ToString());
 */
 
 //ARRAY BIDIMENSIONALES
 //Declarando un array conociendo el numero de elementos pero sin saber los elementos:
int [,] arr2D = new int[2,2];
for (int j = 0; j < 2; j++) // -> j = 0, 1 :representa las filas
{
 for (int k = 0; k < 2; k++) // -> k = 0, 1 : respresenta las columnas
 {
  arr2D[j, k] = j + k;
  Console.Write(arr2D[j,k] + " ");
 }
 Console.WriteLine();
}

//Nos interesa que existan los pares de valores 0, 0, para poder acceder a las distintas posiciones del arrary bidemencional
// (0,0) -> arr2d[0,0]
/* Comprobación operación anterior:
 * (0,0) -> arr2d[0,0] -> 0
 * (0,1) -> arr2d[0,0] -> 1
 * (1,0) -> arr2d[0,0] -> 1
 * (1,1) -> arr2d[0,0] -> 2
 */
Console.WriteLine("\nOtra Matriz:\n");
int size = 2;
int [,] arr2D2 = new int[size,size];

for (int j = 0; j < size; j++) // -> j = 0, 1 :representa las filas
{
 for (int k = 0; k < size; k++) // -> k = 0, 1 : respresenta las columnas
 {
  arr2D2[j, k] = j + k;
  Console.Write(arr2D2[j,k] + "\t");
 }
 Console.WriteLine();
}

//Declaramos una matriz y asignamos los valores de los elementos:
int[,] matriz = {{1,2,3},{4,5,6} };
Console.WriteLine($"\nRank: {matriz.Rank}");
Console.WriteLine($"\nTamaño: {matriz.Length}");
Console.WriteLine("\nOtra Matriz:\n");
for (int j = 0; j < 2; j++) // -> j = 0, 1 :representa las filas
{
 for (int k = 0; k < 3; k++) // -> k = 0, 1, 2 : respresenta las columnas
 {
  Console.Write(matriz[j,k] + "\t");
 }
 Console.WriteLine();
}

//Declaramos una matriz cuando no conocemos filas y columnas
int[][] matriz2 = new int[3][];
matriz2[0] = new int[] {1,2,3,4}; // en la fila 0 asignamos 4 columnas con estos valores
matriz2[1] = new int[] {3,4,5,6};
matriz2[2] = new int[] {5,6,7,8};
Console.WriteLine($"\nTamaño: {matriz2.Rank}");
Console.WriteLine("\nOtra Matriz:\n");

for (int j = 0; j < 3; j++) // -> j = 0, 1 :representa las filas
{
 for (int k = 0; k < 4; k++) // -> k = 0, 1, 2 : respresenta las columnas
 {
  if (matriz2[j][k] != null)
  {
   Console.Write(matriz2[j][k] + "\t");
  }
  else
  {
   matriz2[j][k] = 0;
   Console.Write(matriz2[j][k] + "\t");
  }
 }
 Console.WriteLine();
}
//SUMA DE MATRICES
/*
 * A = (1,2)
 *     (3,4)
 * B = (-1,0)
 *     (0,-1)
 * RESULTADO=
 * C = (0,2)
 *     (3,3) 
 */
  
 int [,] a = {{1,2},{3,4}};
 int [,] b = {{-1,0},{0,-1}};
 int [,] c = {{0,0},{0,0}};

Console.WriteLine("\nSUMA DE MATRICES:\n");
for (int j = 0; j < 2; j++) // -> j = 0, 1 :representa las filas
{
 for (int k = 0; k < 2; k++) // -> k = 0, 1, 2 : respresenta las columnas
 {
  c[j,k] = a[j,k] + b[j,k];
  Console.Write(c[j ,k] + "\t");
 }
 Console.WriteLine();
}