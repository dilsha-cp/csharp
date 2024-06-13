using System.IO.Pipes;

namespace third
{
    
    
    public class Program
    {
        private enum Gender
        {
            Male,
            Female,
            others
        }
        static void Main(string[] args)
        {
            Gender p1= Gender.Male;
            Gender p2= Gender.Female;
            Console.WriteLine($"Gender of p1 is {p1}");
            Console.WriteLine($"Gender of p2 is {p2}");
            // get set property
            get_set pobj = new get_set();
            pobj.Name = "Dilsha";
            Console.WriteLine($"Name:{pobj.Name}");

        }
    }
}
// enum 