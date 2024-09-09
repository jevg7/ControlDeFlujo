using System;

public class Program
{
    public static void Main()
    {
        int number;
        
        Console.Write("Ingrese un número: ");
        number = int.Parse(Console.ReadLine());

       
        int sumOdds = 0;

        
        for (int i = 1; i <= number; i++)
        {
            
            if (i % 2 == 0)
            {
                sumOdds += i;
            }
        }

        Console.WriteLine("La suma de los números pares entre 1 y " + number + " es: " + sumOdds);

    }
}
