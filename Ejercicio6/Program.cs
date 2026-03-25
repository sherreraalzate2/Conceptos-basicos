using System;

class TaxCalculator
{
    static void Main()
    {
        Console.Write("Ingrese su salario anual: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario > 12000)
        {
            double excedente = salario - 12000;
            double impuesto = excedente * 0.15;
            Console.WriteLine($"Resultado: {impuesto}");
        }
        else
        {
            Console.WriteLine("Resultado: No debe impuestos.");
        }
    }
}