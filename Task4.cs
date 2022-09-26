using System;

namespace CSharpTasks
{
    class Task4
    {
        public string ReversedString(string properOrder)
        {
            string reversedString=String.Empty;
            char[] reverse= properOrder.ToCharArray();
            for(int i=reverse.Length-1;i>-1;i--)
            {
              reversedString= reversedString+reverse[i];
            }
            return reversedString;
        }
        
    }
}