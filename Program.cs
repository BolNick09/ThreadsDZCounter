namespace ThreadsDZ1
{
    internal class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[4];
            for (int i = 0; i < threads.Length; i++)   
            {
                threads[i] = new Thread(IncrementCount);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
                threads[i].Join();

            Console.WriteLine(count);
        }


        private static void IncrementCount()
        {
            for (int i = 0; i < 100000; i++)
                count++;
        }
    }
}
