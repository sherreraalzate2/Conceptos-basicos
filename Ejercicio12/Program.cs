using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el cuarto número: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el quinto número: ");
        double n5 = Convert.ToDouble(Console.ReadLine());

        double menor = n1;

        if (n2 < menor) menor = n2;
        if (n3 < menor) menor = n3;
        if (n4 < menor) menor = n4;
        if (n5 < menor) menor = n5;

        Console.WriteLine("Resultado: " + menor);
    }
}