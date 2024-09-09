using System;

    public class Program
{
    public static void Main()
    {
        int max = int.MinValue; 
        int min = int.MaxValue; 

        Console.WriteLine("Ingrese una serie de numeros (Ingrese 0 para detener):");

        
        for (; ; )
        {
            
            int number = int.Parse(Console.ReadLine());

            
            if (number == 0)
            {
                break;
            }

           
            if (number > max)
            {
                max = number;
            }

            
            if (number < min)
            {
                min = number;
            }
        }

        
        if (max == int.MinValue && min == int.MaxValue)
        {
            Console.WriteLine("No se ingresaron numeros.");
        }
        else
        {
            
            Console.WriteLine("Numero mayor: " + max);
            Console.WriteLine("Numero menor: " + min);
        }
    }
}
