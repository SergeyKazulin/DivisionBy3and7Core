using System;


namespace DivisionBy3and7Core
{
    class Program
    {
        static void Main(string[] args)

        {
            int number;
            Console.WriteLine("Введите целое число: ");
            number = Int32.Parse(Console.ReadLine());
            if (number % 3 == 0 & number % 5 == 0)
                Console.WriteLine("FizzBuzz");
            
            else if (number % 3 == 0)
                Console.WriteLine("Fizz");
            
            else if (number % 5 == 0)
                Console.WriteLine("Buzz");
            
            else 
                Console.WriteLine("No Fizz, No Buzz");
            
            Console.ReadKey();

        }    
           
    }

}
