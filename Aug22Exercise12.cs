namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("enter size");
            n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Maximum element {0}\nMinimum element {1}", max, min);
            Console.ReadLine();

        }
    }
}