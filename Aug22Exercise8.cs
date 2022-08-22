using System.Collections;
namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Coffee");
            h.Add(2, "Tea");
            h.Add(3, "Boost");
            h.Add(4, "horlicks");
            IDictionaryEnumerator he= h.GetEnumerator();
            Console.WriteLine("Using While loop");
            while (he.MoveNext())
            {
                Console.Write("{0}\t",he.Key);
                Console.Write("{0}\n", he.Value);
            }
            Console.WriteLine("Using for each loop");
            foreach(DictionaryEntry values in h)
            {
                Console.Write("{0}\t", values.Key);
                Console.Write("{0}\n", values.Value);
            }
            Console.ReadLine();

        }
    }
}