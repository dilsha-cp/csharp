namespace Anonymous1
{
    internal class Program
    {
        public delegate void print(int value);
        static void Main(string[] args)
        {
            int i = 10;
            print prt = delegate (int val)
            {
                val += i;
                Console.WriteLine(val);

            };
            prt(100);
        }
    }
}
