using System.Collections;
namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s=new Stack();
            Console.WriteLine("Pushing");
            for(int i=0;i<4;i++)
            {
                s.Push(i);
            }
           object a1=s.Pop();
            Console.WriteLine("Popped Element {0} ", a1);
            int cnt = s.Count;
            Console.WriteLine("Count {0} ", cnt);
            Console.WriteLine("Top element {0}",s.Peek());



            Console.ReadLine();

        }
    }
}