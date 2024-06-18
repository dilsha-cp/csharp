namespace delegates
{
    delegate int ArithOpe(int a, int b);
    delegate void MDelegate();


    internal class Program
    {
        static void Main(string[] args)
           {
            //Delegate instance
            ArithOpe ope1=new ArithOpe(dtest.add);
            ArithOpe ope2 = new ArithOpe(dtest.sub);
            //Invoking delegates
            int result1 = ope1(200, 300);
            int result2 = ope2(300, 200);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            MDelegate m1=new MDelegate(mdTest.Display);
            MDelegate m2 = new MDelegate(mdTest.print);
            MDelegate m3 = m1 + m2;
            MDelegate m4 = m2 + m1;
            MDelegate m5 = m3- m1;
            m3();
            m4();
            m5();



        }
    }
}
        
    

