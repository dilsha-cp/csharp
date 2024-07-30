namespace anonymous
{
    internal class Program
    {
        public delegate int SumDeligate(int x,int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SumDeligate sd=delegate (int x,int y) {  return x + y; };
            Console.WriteLine(sd(20, 30));

        }
    }
}
