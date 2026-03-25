using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("Resultado: " + Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("Resultado: " + (numero * numero));
        }
    }
}
