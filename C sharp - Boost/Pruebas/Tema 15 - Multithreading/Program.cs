// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Security.Cryptography;

Console.WriteLine("MULTITHREADING");
/*
//Sin Multithreading
//A esto se le llama programar de forma sincrona secuencial, cada tarea sigue una vez finalizada la anterior.
Stopwatch crono = Stopwatch.StartNew();

//tarea 1.
Thread.Sleep(1000); //emulamos una tarea que tarda un segundo.

//tarea 2.
for (int i = 0; i < 1000000000; i++)
{
   i *= 1;
}

//tarea 3.
Thread.Sleep(1000);

crono.Stop();
Console.WriteLine($"Este programa se ha ejecutado en: {crono.Elapsed} segundos.");
*/
//siempre comenzamos desde el "main thread" o "hilo principal".
//y delegamos en "hilos secundarios" las tareas que no queremos que tengan
// detenido nuestro programa o flujo de trabajo.
//MAIN THREAD.
 Thread mainThread = Thread.CurrentThread;
mainThread.Name = "Hilo Principal"; //Dar nombre a los hilos es opcional, pero nos sirve para organizar y gestionar
// el resto de los hilos.
Console.WriteLine($"Estamos en el hilo {mainThread.Name}");

 