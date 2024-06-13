using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    public class Class1
    {
        public Class1()
            {

            }
         public void Implicit()
         {
        int myInt = 9;
        double myDouble = myInt;       // Automatic casting: int to double
        Console.WriteLine(myInt);     
        Console.WriteLine(myDouble);
         }
        public void Explicit()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);  
            Console.WriteLine(myInt);
        }
      
        
    }
}
