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
           
           int m=0,k=0;
            int flag = 0;
            for(int i= 0;i <arr.Length;i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        m = i;
                        k = arr[i];
                        flag = 1;
                        break;
                    }
                }
                    if (flag != 0)
                    {
                        break;
                    }
                
             }
            Console.WriteLine("smallest index {0} and repeating integer {1}",m,k);
            Console.ReadLine();

        }
    }
}