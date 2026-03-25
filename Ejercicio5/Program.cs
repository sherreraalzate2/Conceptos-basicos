using System;

class MidweekDay
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 1 && numero <= 5)
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            Console.WriteLine($"Resultado: {dias[numero - 1]}");
        }
        else
        {
            Console.WriteLine("Resultado: Número fuera del rango laboral.");
        }
    }
}