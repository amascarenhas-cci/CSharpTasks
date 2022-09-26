using System;

namespace CSharpTasks
{
    class Task1
    {
        static void Main(string[] args)
        {
            //Task2 t2=new Task2();
            //Task3 t3=new Task3();
            Task4 t4=new Task4();

            //int age,number;
            string[] properOrder= new string[6];

            /*Console.WriteLine("Enter your age in years");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Days: "+ calcAge(age));

            Console.WriteLine("Enter your age in years");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Seconds: "+ t2.calcAge(age));

            Console.WriteLine("Enter a number ");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:"+ t3.cubes(number));*/

            Console.WriteLine("Enter a string to be reversed");
            for(int i=0;i<6;i++)
            {
              properOrder[i]=Console.ReadLine();
            }

             t4.ReversedString(properOrder);
            //Console.WriteLine("Reversed String"+ t4.ReversedString(properOrder));
        }

        static int calcAge(int age)
        {
            age=age*365;
            return age;
        }

    }
    
}

