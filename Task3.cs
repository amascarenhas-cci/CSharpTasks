using System;

namespace CSharpTasks
{
    class Task3
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number ");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:"+ cubes(number));
        }
        
        static int cubes(int a)
        {
            return a*a*a;
        }
    }
}
