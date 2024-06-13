namespace variable

{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            long num2 = 12345;
            float num3 = 1.5f;
            double num4 = 2.9876;
            bool num5 = true;
            string name = "dilsha";
            char name1 = 'a';
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(name);
            Console.WriteLine(name1);
            int c = num1 * num1;
            Console.WriteLine(c);
            // To change variable
            int mynum = 10;
            mynum = 20;
            Console.WriteLine($"num:{mynum}");
           
            Class1 myobj=new Class1();
            myobj.Implicit();
            myobj.Explicit();


        }
    }
}
//writeline and write is used to print writeline new line
//The const keyword is useful when you want a variable to always store the same value,
//so that others (or yourself) won't mess up your code
//const int z= 10;
//z = 20;
// Console.WriteLine(z);//show error