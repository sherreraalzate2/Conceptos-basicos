using System;

class AverageOfFour
{
    static void Main()
    {
        double suma = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += Convert.ToDouble(Console.ReadLine());
        }

        double promedio = suma / 4;
        Console.WriteLine($"Resultado: {promedio}");
    }
}