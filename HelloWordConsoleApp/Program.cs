// See https://aka.ms/new-console-template for more information
using HelloWordConsoleApp;

public static class sayHello
{
    public static void Main(){
    var person = new Person();
    person.Name = "Jhon";
    person.Age = 18;

    string message = $"Hello Mr {person.Name} your age is {person.Age}";
    Console.WriteLine(message);
    Console.ReadLine();
    }

}


