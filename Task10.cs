using System;

namespace CSharpTasks
{
    class Task10
    {
         
      public void analyzeJson(int jsonFields)
      {
        string[,] arr = new string[jsonFields,2];
        
        for(int i=0;i<jsonFields;i++)
        {
          Console.WriteLine("Enter key followed by value");
          for(int j=0;j<2;j++)
          {
            arr[i,j]=Console.ReadLine();
          }
        }
        Console.WriteLine();
        Console.WriteLine("INPUT:");
        Console.WriteLine("{");
        for(int i=0;i<jsonFields;i++)
        {
          for(int j=0;j<2;j++)
          {
            if(j==0)
            {
               Console.Write("\""+arr[i,j]+"\":");
            }
            else
            {
              Console.WriteLine(arr[i,j]);
            }
           
          }
        }
         Console.WriteLine("}");
           Console.WriteLine();
            Console.WriteLine("OUTPUT:");

        for(int i=0;i<jsonFields;i++)
        {
          Console.WriteLine(arr[i,0]);
        }
      }

    }
    
}