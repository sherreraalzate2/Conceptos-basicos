using System;

class RemainderFinder
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int residuo = num1 % num2;
        Console.WriteLine($"Resultado: {residuo}");
    }
}