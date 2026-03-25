using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contador = 0;

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
            {
                contador++;
            }
        }

        Console.WriteLine("Resultado: " + contador);
    }
}