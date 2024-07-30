namespace Threading
{
    public class Program
    {
        static void PrintNumbers(String threadname)
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{threadname}:{i}");
                Thread.Sleep(500);

            }
        }
        static void Main(string[] args)
        {
            Thread thread1=new Thread(()=> PrintNumbers("Thread 1"));
            Thread thread2 = new Thread(()=> PrintNumbers("Thread 2"));
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Main Thread is counting to run");
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Both thread have finish the execution");
        }
    }
}
