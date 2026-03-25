using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número del 1 al 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Resultado: Lunes");
                break;
            case 2:
                Console.WriteLine("Resultado: Martes");
                break;
            case 3:
                Console.WriteLine("Resultado: Miércoles");
                break;
            case 4:
                Console.WriteLine("Resultado: Jueves");
                break;
            case 5:
                Console.WriteLine("Resultado: Viernes");
                break;
            default:
                Console.WriteLine("Resultado: Número fuera del rango laboral.");
                break;
        }
    }
}