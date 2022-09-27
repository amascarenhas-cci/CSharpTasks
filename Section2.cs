using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Section2
    {
        //Task6
        public int HowManySeconds(int hours,int minutesInHour ,int secondsInMinute)
        {
            int seconds = hours * minutesInHour * secondsInMinute;
            return seconds;
        }

        //Task7

        public void Deal()
        {
            Random random = new Random();
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            for (int i = 5; i > 0; i--)
            {
                int index1 = random.Next(0, 12);
                int index2 = random.Next(0, 3);
                Console.WriteLine(faces[index1] + " of " + suits[index2]);

            }


        }

        //Task8

        public void SearchNumber(int arr1Length, int arr2Length)
        {
            int[] array1 = new int[arr1Length];
            int[] array2 = new int[arr2Length];
            int target;
            bool elementInArray1 = false;
            bool elementInArray2 = false;

            Console.WriteLine("Enter elements for the first array");
            for (int i = 0; i < arr1Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elements for the second array");
            for (int i = 0; i < arr2Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to be found ");
            target = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr1Length; i++)
            {
                if (array1[i] == target)
                {
                    elementInArray1 = true;
                }
            }


            for (int i = 0; i < arr2Length; i++)
            {
                if (array2[i] == target)
                {
                    elementInArray2 = true;
                }
            }

            if (elementInArray1 && elementInArray2)
            {
                Console.WriteLine("Number found in both arrays");
            }
            else if (elementInArray1)
            {
                Console.WriteLine("Number found in first array");
            }
            else if (elementInArray2)
            {
                Console.WriteLine("Number found in second array");
            }
            else
            {
                Console.WriteLine("Number not found in either array");
            }

        }

        //Task9
        public void CheckString(string testString)
        {
            int uniqueCount = 0, duplicateCount = 0;
            char[] duplicateCharacters = new char[100];
            char[] uniqueCharacters = new char[100];
            testString = testString.ToLower();

            for (int i = 0; i < testString.Length; i++)
            {
                for (int j = 0; j < testString.Length; j++)
                {
                    if ((testString[i] == testString[j]) && (i != j) && (testString[i] != ' '))
                    {
                        duplicateCharacters[i] = testString[i];

                    }
                }
            }

            for (int i = 0; i < testString.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < testString.Length; j++)
                {
                    if ((testString[i] == testString[j]) && (i != j) && (testString[i] != ' '))
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 0)
                    uniqueCharacters[i] = testString[i];
            }

            List<Char> unique = uniqueCharacters.ToList();
            unique = unique.Distinct().ToList();

            Console.WriteLine("Unique Charaters:");
            foreach (char item in unique)
            {
                Console.Write(item);
            }
            uniqueCount = unique.Count - 2;
            Console.WriteLine("\nuniqueCharacterCount:" + uniqueCount);


            List<Char> duplicates = duplicateCharacters.ToList();
            duplicates = duplicates.Distinct().ToList();
            Console.WriteLine("Duplicate Charaters:");
            foreach (char item in duplicates)
            {
                Console.Write(item);
            }
            duplicateCount = duplicates.Count() - 1;
            Console.WriteLine("\nduplicateCharacterCount:" + duplicateCount);
        }

        //Task10

        public void AnalyzeJson(int jsonFields)
        {
            string[,] array = new string[jsonFields, 2];

            for (int i = 0; i < jsonFields; i++)
            {
                Console.WriteLine("Enter key followed by value");
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("INPUT:");
            Console.WriteLine("{");
            for (int i = 0; i < jsonFields; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("\"" + array[i, j] + "\":");
                    }
                    else
                    {
                        Console.WriteLine(array[i, j]);
                    }

                }
            }
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("OUTPUT:");

            for (int i = 0; i < jsonFields; i++)
            {
                Console.WriteLine(array[i, 0]);
            }
        }
    }
}