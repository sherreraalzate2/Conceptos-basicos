using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu salario anual: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario > 12000)
        {
            double impuesto = (salario - 12000) * 0.15;
            Console.WriteLine("Resultado: " + impuesto);
        }
        else
        {
            Console.WriteLine("Resultado: No debe impuestos.");
        }
    }
}