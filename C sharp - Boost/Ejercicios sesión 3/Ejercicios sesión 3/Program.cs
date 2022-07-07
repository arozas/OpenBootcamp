// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

Console.WriteLine("EJERCICIOS SESIÓN 3");

Client newClient = new Client("Alejandro", "Rozas","15-6275-5583","alejandro.rozas@gmail.com",true);

Console.WriteLine(newClient);

public struct Client
{
    public Client (string name, string surnname, string phone,string email, bool newClient)
    {
        Name = name;
        Surname = surnname;
        Phone = phone;
        Email = email;
        NewClient = newClient;
    }

    public string Name { get; set; }

    public string Surname { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public bool NewClient { get; set; }
    
    public override string ToString() => $"{Name},{Surname},{Phone},{Email},{NewClient}";
}
