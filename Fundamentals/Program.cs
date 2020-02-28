using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // book object/instance of the book class
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            // new object
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "JRR Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            if(book2.author == "JRR Tolkien")
                Console.WriteLine("a really good book");
        }
    }
}
