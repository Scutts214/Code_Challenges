using System;
using System.Runtime.CompilerServices;

namespace MyProfile;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string? name = Console.ReadLine();
        Console.Clear();
        Console.Write("Enter Age: ");
        string age = Console.ReadLine();
         Console.Clear();
        Console.Write("Enter Your Favorite Color: ");
        string favoriteColor = Console.ReadLine();
         Console.Clear();

        Console.WriteLine($"Name: {name}\nAge: {age}\nFavorite Color:\n{favoriteColor}");
        Console.Read();
    }
}
