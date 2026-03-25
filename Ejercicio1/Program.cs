using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("Resultado: " + (numero * numero));
        }
        else if (numero == 0)
        {
            Console.WriteLine("Resultado: 0");
        }
        else
        {
            Console.WriteLine("Resultado: Número negativo.");
        }
    }
}