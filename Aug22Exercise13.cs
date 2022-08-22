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
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 100)
                    count++;
                
            }
            Console.Write("Number of elemnts greater than 100: {0}\n",count);
            Console.ReadLine();

        }
    }
}