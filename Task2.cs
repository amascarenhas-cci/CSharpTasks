using System;

namespace CSharpTasks
{
    class Task1
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age in years");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Seconds: "+ calcAge(age));
        }

        static int calcAge(int age)
        {
            age=age*365*24*60*60;
            return age;
        }

    }
    
}

