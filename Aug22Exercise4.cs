using System.Collections;
namespace Aug22Exercises
{
 
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = new ArrayList();
            int k;
            Console.WriteLine("Enter 5 numbers");
           for(int i = 0; i < 5; i++)
            {
                k=Convert.ToInt32(Console.ReadLine());
                a.Add(k);
            }
            Console.WriteLine("Enter number to be removed");
            int kk;
            kk= Convert.ToInt32(Console.ReadLine());
            a.Remove(kk);
            Console.WriteLine("removed"+" "+kk);
            Console.WriteLine("Array after removed");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            int p=a.Count;
            Console.WriteLine("Number of elements in array");
            Console.WriteLine("Count"+" "+p);
            Console.ReadLine();



        }
    }
}