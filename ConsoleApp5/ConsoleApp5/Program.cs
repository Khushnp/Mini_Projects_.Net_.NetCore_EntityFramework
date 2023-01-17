using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainingDB2Entities context= new TrainingDB2Entities();
            var authors = context.getAllAuthor();
            foreach(var author in authors)
            {
                Console.WriteLine(author.id+" "+author.FirstName);
            }
            Console.WriteLine();


            var stu = context.getAllBooks();
            foreach(var book in stu)
            {
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(book.id+"  |  "+book.Name);
            }

            Console.ReadKey();
        }
    }
}
