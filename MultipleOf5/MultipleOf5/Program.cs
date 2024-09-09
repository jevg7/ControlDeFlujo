using System;

public class Program
{
     public static void Main()
    {
       
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

       
        Console.WriteLine("Los multiplos de 5 entre 1 y " + number + " son:");
        for (int i = 1; i <= number; i++)
        {
           
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
