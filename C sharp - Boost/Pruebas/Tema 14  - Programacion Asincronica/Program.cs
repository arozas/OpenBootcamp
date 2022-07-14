using System.Diagnostics;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("PROGRAMACIÓN ASÍNCRONICA");
//Creamos un objeto tipo cronometro.
//Si revisamos la implentación podemos ver sus metodos.
// Se puede iniciar, reiniciar, deterner, resetear...
// tambien podemos controlar si esta en funcionamiento y el tiempo pasado.
//Stopwatch crono = new Stopwatch();
//crono.Start();
//Código, tasks, etc.
//int num = 0;
/*
for (int i = 0; i <= 100; i++)
{
    num += i;
}

//task 1 con task se pueden hacer funciones, métodos, implementar métodos totalmente asincronos 
// hacemos una función lambda o anónima, en este caso para ejemplificar.
*/
Stopwatch sw = Stopwatch.StartNew();//con esta sintaxis podemos crear e inicializar el crono.

var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    //duerme el hilo (genera una pausa) por un segundo.
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 1 demora: {crono.Elapsed}");
    //Con Crono.Elapsed podemos evaluar el tiempo aproxmado en que tarda en resolver una tarea o proceso.
});
var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 2 demora: {crono.Elapsed}");
});
var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 3 demora: {crono.Elapsed}");
}); 
var task4 = new Task(async () =>
{
    string rtn = await RandomAsync();
    Console.WriteLine(rtn);
}); 
//En cada task puedo volver a crear el objeto Stopwatch con el mismo nombre, por que se aplica al scope(ambito, contexto) de esa task
// cada stopwatch funciona y existe en su propio ambito por eso no hay conflicto de nombres en la sintaxis.
task1.Start();
//código, entre cada task podriamos incluir bloques de código y cada task hacer una tárea independiente
//como por ejemplo ir a una página web y recopilar datos que luego usariamos en nuestro código.
task2.Start();
//código
task3.Start();
//Una vez terminada la tarea ṕodemos guardar la información o datos procesados.
task4.Start();

await task1;
await task2;
await task3;
await task4;

sw.Stop();
Console.WriteLine($"Todo el programa tarda en ejecutarse aprox: {sw.Elapsed}");
//FUNCIONES TASK
static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"El numero generado es: {num}, calculado en: {sw.Elapsed}";
    return str;
}
