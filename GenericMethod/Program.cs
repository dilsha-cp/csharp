using System.ComponentModel;

namespace GenericMethod
{
    public class Program
    {
        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"inside the swap method a={a} b={b}");
        }
        static void Add<T>(T a,T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x+y;
            Console.WriteLine($"sum of {a} {b} is:{sum}");
        }
        static void Main(string[] args)
        {
             int a = 10;
             int b=20;
            Swap <int>(a, b);
            Swap<string>("dilsha", "basheer");
            Console.WriteLine($"Before calling swap method a={a} b={b}");
            Add(a, b);
            

        }
    }
}
