using System;

 public class Program
{
     public static void Main()
    {
       
        Console.Write("Ingrese la cantidad de terminos de la serie de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());
 
        if (n <= 0)
        {
            Console.WriteLine("Porfavor ingrese un termino positivo.");
        }
        else
        {
            
            int firstTerm = 0;
            int secondTerm = 1;

            Console.WriteLine("Serie de Fibonacci hasta el termino numero " + n );

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(firstTerm); 
                }
                else if (i == 2)
                {
                    Console.WriteLine(secondTerm); 
                }
                else
                {
                    int nextTerm = firstTerm + secondTerm; 
                    Console.WriteLine(nextTerm); 

          
                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }
            }
        }
    }
}
