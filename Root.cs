using System;

namespace CSharpTasks
{
    class Root
    {
        public static void Main(string[] args)
        {
            int arr1Length, arr2Length, age, number, hours;
            int choiceToDeal = 1;
            const int NoOfDaysInYear = 365;
            const int HoursInDay = 24;
            const int MinutesInHour = 60;
            const int SecondsInMinute = 60;
            string testString, properOrder;

            Section1 s1 = new Section1();
            Section2 s2 = new Section2();

            Console.WriteLine("Enter your age in years to be converted to days");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Days: " + s1.CalcAge1(age, NoOfDaysInYear));

            Console.WriteLine("Enter your age in years");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age in Seconds: " + s1.CalcAge2(age, NoOfDaysInYear, HoursInDay, MinutesInHour, SecondsInMinute));

            Console.WriteLine("Enter a number to be cubed");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:" + s1.Cubes(number));

            Console.WriteLine("Enter a string to be reversed");
            properOrder = Console.ReadLine();
            Console.WriteLine("Reversed String: " + s1.ReversedString(properOrder));

            Console.WriteLine("Enter size for the array");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            s1.TargetIndices(arraySize);

            Console.WriteLine("Enter the number of hours to be converted to Seconds");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours in Seconds: " + s2.HowManySeconds(hours,MinutesInHour,SecondsInMinute));

            while (choiceToDeal != 0)
            {
                s2.Deal();
                Console.WriteLine("Enter 1 to deal again or 0 to quit");
                choiceToDeal = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of the first array");
            arr1Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of the second array");
            arr2Length = Convert.ToInt32(Console.ReadLine());
            s2.SearchNumber(arr1Length, arr2Length);



            Console.WriteLine("Enter a string");
            testString = Console.ReadLine();
            s2.CheckString(testString);

            Console.WriteLine("Enter number of fields for Json file");
            int jsonFields = Convert.ToInt32(Console.ReadLine());
            s2.AnalyzeJson(jsonFields);

        }
    }

}

