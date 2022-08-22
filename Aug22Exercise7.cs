using System.Collections;
namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(10, 2);//FIFO--First in first out
            q.Enqueue(45);
            q.Enqueue(4567.45f);
            q.Enqueue(33);
            //object a2=q.Dequeue();//45
            //Console.WriteLine(a2);

            q.Peek();
            Console.WriteLine("Before trimming=" + q.Count);
            q.TrimToSize();
            Console.WriteLine("After trimming");
            Console.WriteLine(q.Count);
            Console.WriteLine("Q elements are ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}