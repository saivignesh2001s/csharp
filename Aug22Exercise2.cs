namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int k;
            Console.WriteLine("enter size");
            k=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine("Enter the numbers");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter n");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reversed array");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();

        }
    }
}