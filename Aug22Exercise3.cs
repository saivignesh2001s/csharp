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
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
                Console.WriteLine("sum after element {0}:{1}", i, sum);
            }
            Console.ReadLine();
        }
    }
}