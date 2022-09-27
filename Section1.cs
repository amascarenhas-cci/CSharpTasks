using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{

    public class Section1
    {

        //Task1
        public int CalcAge1(int age, int noOfDaysInYear)
        {
            age = age * noOfDaysInYear;
            return age;
        }
        //Task2
        public int CalcAge2(int age, int noOfDaysInYear, int hoursInDay, int minutesInHour, int secondsInMinute)
        {
            age = age * noOfDaysInYear * hoursInDay * minutesInHour * secondsInMinute;
            return age;
        }

        //Task3
        public int Cubes(int number)
        {
            return number * number * number;
        }

        //Task4
        public string ReversedString(string properOrder)
        {
            string reversedString = String.Empty;
            char[] reverse = properOrder.ToCharArray();
            for (int i = reverse.Length - 1; i > -1; i--)
            {
                reversedString = reversedString + reverse[i];
            }
            return reversedString;
        }

        //Task5
        public void TargetIndices(int arraySize)
        {
            int result, indice1, indice2;
            int[] integers = new int[arraySize];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < arraySize; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the target");
            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    result = integers[i] + integers[j];
                    if (result == target)
                    {
                        indice1 = i;
                        indice2 = j;
                        Console.WriteLine("Indices of target:" + indice1 + "," + indice2);
                        break;
                    }
                }
            }
        }
    }
}

