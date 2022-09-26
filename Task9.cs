using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTasks
{
    class Task9
    {
         
         int uniqueCount=0,duplicateCount=0;
         char[] duplicateCharacters=new char[100];
         char[] uniqueCharacters=new char[100];
        public void checkString(string testString)
        {
          testString=testString.ToLower();
          //Console.WriteLine("FIRST:"+testString[0]);
          for(int i=0;i<testString.Length;i++)
          {
            for(int j=0;j<testString.Length;j++)
            {
                if((testString[i]==testString[j])&&(i!=j)&&(testString[i]!=' '))
               {
                duplicateCharacters[i]=testString[i];
              
               }
            }
          }

          for(int i=0;i<testString.Length;i++)
          {
            int flag=0;
            for(int j=0;j<testString.Length;j++)
            {
                if((testString[i]==testString[j])&&(i!=j)&&(testString[i]!=' '))
               {
                flag=1;
                break;
               }
               
            }
            if (flag == 0)
            uniqueCharacters[i]=testString[i];
          }

          List<Char> unique=uniqueCharacters.ToList();
           unique=unique.Distinct().ToList();

          Console.WriteLine("Unique Charaters:");
          foreach(char item in unique)
          {
            Console.Write(item);
          }
          uniqueCount=unique.Count-2;
          Console.WriteLine("\nuniqueCharacterCount:"+uniqueCount);


         List<Char> duplicates=duplicateCharacters.ToList();
           duplicates=duplicates.Distinct().ToList();
          Console.WriteLine("Duplicate Charaters:");
          foreach(char item in duplicates)
          {
            Console.Write(item);
          }
          duplicateCount=duplicates.Count()-1;
          Console.WriteLine("\nduplicateCharacterCount:"+duplicateCount);
        }

    }
    
}