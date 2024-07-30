namespace genericdelegate
{
    internal class Program
    {
        public delegate T AddDelegate<T>(T param, T param2);
        static void Main(string[] args)
        {
            AddDelegate<int> sum = AddNumber;
            Console.WriteLine(sum(10,20));
            AddDelegate<string> cont = Concate;
            Console.WriteLine(cont("Hello", "world"));

        }
        public static int AddNumber(int val1,int val2)
        {
            return val1 + val2;
        }
        public static string Concate(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
