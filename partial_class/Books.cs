using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public partial class Books
    {
        public string Author_name;
        public string Book_no;
        public void printDetails(string an, string bn)
        {
            this.Author_name = an;
            this.Book_no = bn;
            Console.WriteLine($"Author name:{Author_name}\n Book_no: {Book_no}");
        }

    }
    public partial class Books
    {
        public string Bookname;
        public string publishername;
        public void PrintpublisherDetails()
        {
            
            Console.WriteLine($"Book name:{Bookname}\n Publisher name: {publishername}");

        }
    }
    public partial class Books
    {
        public static void Main(string[] args)
        {
            Books b1 = new Books();
            b1.printDetails("Ansha","101");
            Books b2 = new Books();
            Console.WriteLine("enter the book name");
            b2.Bookname = Console.ReadLine();
            Console.WriteLine("enter the publisher name");
            b2.publishername = Console.ReadLine();

            b1.PrintpublisherDetails();
        }
    }
}
