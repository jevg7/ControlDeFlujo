using System;

    public class Programa
{
    public static void Main()
    {
        int number;

        Console.Write("Ingrese un numero: ");
        number = int.Parse(Console.ReadLine());

        
        if (number < 0)
        {
            Console.WriteLine("El factorial no está definido para números negativos.");
        }
        else
        {
            
            long factorial = 1;  
            int i = 1;

            
            while (i <= number)
            {
                factorial *= i; 
                i++; 
            }

            
            Console.WriteLine("El factorial de " + number + " es: " + factorial);
        }
    }
}
