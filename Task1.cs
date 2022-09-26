using System;

namespace CSharpTasks
{
    class Task1
    {
        static void Main(string[] args)
        {

            Task7 t7=new Task7();
            Task8 t8=new Task8();
             int arr1Length,arr2Length;
           
            Task5 t5=new Task5();
            Task2 t2=new Task2();
            Task3 t3=new Task3();
            Task4 t4=new Task4();
            Task6 t6=new Task6();
            
            int age,number,hours;
            string properOrder;
           

            Console.WriteLine("Enter your age in years");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Days: "+ calcAge(age));

            Console.WriteLine("Enter your age in years");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Seconds: "+ t2.calcAge(age));

            Console.WriteLine("Enter a number ");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:"+ t3.cubes(number));

            Console.WriteLine("Enter a string to be reversed");
            properOrder=Console.ReadLine();
            Console.WriteLine("Reversed String: "+ t4.ReversedString(properOrder));

            Console.WriteLine("Enter size for the array");
            int arraySize=Convert.ToInt32(Console.ReadLine());
            t5.TargetIndices(arraySize);

            Console.WriteLine("Enter the number of hours to be converted");
            hours=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours in Seconds: "+ t6.howManySeconds(hours));

            Console.WriteLine("Enter the size of the first array");
            arr1Length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array");
            arr2Length=Convert.ToInt32(Console.ReadLine());
            t8.SearchNumber(arr1Length,arr2Length);

            t7.Deal();

        }

        static int calcAge(int age)
        {
            age=age*365;
            return age;
        }

    }
    
}

