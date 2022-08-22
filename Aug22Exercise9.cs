namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<float> K = new List<float> { 0.01f, 0.93f, 9.3f };
            float[] arr = new float[K.Count];
            for (int i = 0; i < K.Count; i++)
            {
                arr[i] = K[i];
            }
            Array.Sort(arr);
            Console.WriteLine("Ascending Order");
            foreach (float f in arr)
            {
                Console.WriteLine(f);
            }
            Array.Reverse(arr);
            Console.WriteLine("Descending Order");
            foreach (float f in arr)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
       
}