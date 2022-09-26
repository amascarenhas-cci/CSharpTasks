using System;

namespace CSharpTasks
{
    class Task8
    {
         
        public void SearchNumber(int arr1Length,int arr2Length)
        {
            int[] arr1=new int[arr1Length];
            int[] arr2=new int[arr2Length];
            int target;
            int flag1=0;
            int flag2=0;

            Console.WriteLine("Enter elements for the first array");
            for(int i=0;i<arr1Length;i++)
            {
                arr1[i]=Convert.ToInt32(Console.ReadLine());
            }
             Console.WriteLine("Enter elements for the second array");
            for(int i=0;i<arr2Length;i++)
            {
                arr2[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to be found ");
            target=Convert.ToInt32(Console.ReadLine());

             for(int i=0;i<arr1Length;i++)
            {
                if(arr1[i]==target)
                {
                    flag1=1;
                }
            }

            
             for(int i=0;i<arr2Length;i++)
            {
                if(arr2[i]==target)
                {
                    flag2=1;
                }
            }

            if(flag1==1&&flag2==1)
            {
                Console.WriteLine("Number found in both arrays");
            }
            else if(flag1==1&&flag2==0)
            {
                 Console.WriteLine("Number found in first array");
            }
            else if(flag1==0&&flag2==1)
            {
                 Console.WriteLine("Number found in second array");
            }
            else
            {
                Console.WriteLine("Number not found in either array");
            }
            
        }

    }
    
}