using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequence of numbers separated by white space");
            var input = Console.ReadLine();
            try
            {
                int[] intArray = Array.ConvertAll(input.Split(' '), s => int.Parse(s));
                int result = Utils.GetSingleNumber(intArray);
                if (result == -1) Console.WriteLine("Invalid array");
                else Console.WriteLine("Single number is: " + result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid array");
                Console.ReadKey();
            }
            
        }
    }
}
