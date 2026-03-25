using System;

class FractionDifference
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera fracción:");
        Console.Write("Numerador 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Denominador 1: ");
        int den1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda fracción:");
        Console.Write("Numerador 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Denominador 2: ");
        int den2 = Convert.ToInt32(Console.ReadLine());

        // Calcular diferencia: a/b - c/d = (a*d - c*b) / (b*d)
        int numerador = (num1 * den2) - (num2 * den1);
        int denominador = den1 * den2;

        // Simplificar la fracción
        int mcd = MCD(Math.Abs(numerador), denominador);
        numerador /= mcd;
        denominador /= mcd;

        if (numerador == 0)
        {
            Console.WriteLine("Resultado: 0");
        }
        else if (denominador == 1)
        {
            Console.WriteLine($"Resultado: {numerador}");
        }
        else
        {
            Console.WriteLine($"Resultado: {numerador}/{denominador}");
        }
    }

    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}