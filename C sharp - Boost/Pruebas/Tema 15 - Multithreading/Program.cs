// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Net.Http.Headers;

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
mainThread.Name = "Hilo Principal"; 
//Dar nombre a los hilos es opcional, pero nos sirve para organizar y gestionar
// el resto de los hilos.
Console.WriteLine($"Estamos en el hilo {mainThread.Name}");
Stopwatch crono = Stopwatch.StartNew();
//Lo ideal seria crear un task
var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    ThreadStart refhilo = InitializeThreads;
    Thread secondaryThread = new Thread(refhilo);
    secondaryThread.Start();
    crono.Stop();
    Console.WriteLine($"1. El hilo se ha ejecutado en: {crono.Elapsed}");
});

var task2 = new Task(() =>
{
    //Lo ideal seria crear un task
    Stopwatch crono2 = Stopwatch.StartNew();
    ThreadStart refhilo = InitializeThreads;
    Thread thirdThread = new Thread(refhilo);
    thirdThread.Start();
    crono2.Stop();
    Console.WriteLine($"2. El hilo se ha ejecutado en: {crono2.Elapsed}"); 
});

//iniciamos las tareas (task)
task1.Start();
task2.Start();

//recibismo las tareas de forma individual:

await task1;
await task2;

//recibimos las tareas de forma colectiva:
//await Task.WhenAll(task1, task2); //recibimos todas las tareas iniciadas, cuado se completan.
crono.Stop();
Console.WriteLine($"El main thread se ha ejecutado en: {crono.Elapsed}");
//finalizamos el programa.

static void InitializeThreads()
    {
        Console.WriteLine($"Iniciando hilo nuevo...");
        Thread.Sleep(1000);
        Console.WriteLine("Tareas Finalizadas");
    }