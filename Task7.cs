using System;

namespace CSharpTasks
{
    class Task7
    {
        
         Random random=new Random();
        string[] faces={"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
        string[] suits={"Hearts","Clubs","Diamonds","Spades"};
        public void Deal()
        {
           
           for(int i=5;i>0;i--)
           {
            int index1=random.Next(0,12);
            int index2=random.Next(0,3);
            Console.WriteLine(faces[index1]+" of "+suits[index2]);
           
           }
           
           
        }

       



    }
    
}