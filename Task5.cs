using System;

namespace CSharpTasks
{
    class Task5
    {
        int result,indice1,indice2;
        public void TargetIndices(int arraySize)
        {
         int[] integers=new int[arraySize];
         Console.WriteLine("Enter array elements");
         for(int i=0;i<arraySize;i++)
         {
            integers[i]=Convert.ToInt32(Console.ReadLine());
         }

         Console.WriteLine("Enter the target");
         int target=Convert.ToInt32(Console.ReadLine());
          for(int i=0;i<arraySize;i++)
         {
            for(int j=i+1;j<arraySize;j++)
            {
              result=integers[i]+integers[j];
              if(result==target)
              {
                indice1=i;
                indice2=j;
                Console.WriteLine("Indices of target:"+ indice1+","+indice2);
                break;
              }
            }
         }
        }
        
    }
}