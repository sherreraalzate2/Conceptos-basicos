using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine("Resultado: " + perimetro.ToString("F2"));
    }
}