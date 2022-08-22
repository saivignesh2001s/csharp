using System.Collections;
 namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {



            SortedList<int, string> dic = new SortedList<int, string>();
            dic.Add(2, "Hitendra");
            dic.Add(1, "Mohan");
            dic.Add(3, "Simran");

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();


            Console.ReadLine();
        }
    }
       
}