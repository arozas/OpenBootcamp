//GENERICS

Generic<string> str = new Generic<string>();
str.Dato = "dato";
Console.WriteLine(str.Dato);
Console.WriteLine($"Tipo de Generic Dato: {str.Dato.GetType().FullName}");


//COMO SE DEFINEN:
public class Generic<T>
{
    //La "T" define el tipo, es una plantilla, la T es de Template, para definir el tipo Generic.
    public T Dato { get; set; }
}
