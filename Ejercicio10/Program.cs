using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        Console.WriteLine("Resultado: " + palabra.Length);
    }
}