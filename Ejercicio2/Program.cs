using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Resultado: " + (num1 * 2));
        }
        else
        {
            Console.WriteLine("Resultado: " + (num2 * 3));
        }
    }
}
