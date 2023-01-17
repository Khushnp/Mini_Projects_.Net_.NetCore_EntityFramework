using ConsoleApp3.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CrudRelaMulOper
{
    internal class InsertRelaMulOper : DisplayRealMulOpe
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void InsertInAuther()
        {
            List<Author1> author1s = new List<Author1>();

            Console.Write("Enter the number of records you want to insert: ");
            int recordscount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < recordscount; i++)
            {
                Console.Write("Enter the Firstname: ");
                string fn = Console.ReadLine();
                Console.Write("Enter the Lastname: ");
                string ln = Console.ReadLine();

                author1s.Add(new Author1 { FirstName = fn, LastName = ln, AddedDate = DateTime.Now });
                Console.WriteLine();

            }

            context.Author1s.AddRange(author1s);
            context.SaveChanges();
        }



       public void InsertInBook1()
        {
            Console.WriteLine("As going forward ID of the author records will be needed hence Database is Shown");
            displayall();

            Console.Write("Enter the number of Books you want to insert: ");
            int recordscount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < recordscount; i++)
            {
                Console.WriteLine("Enter the Id the of the Author as you are inserting book for him");
                int ID = IdcheckinAuther(); //idcheck function is in displayclass

                Console.Write("Enter the name of the book : ");
                string fn = Console.ReadLine();

                //First name may be Null Condition Handling
                while (fn == null || fn == "" || fn == " ")
                {
                    Console.Write("Book Name Entered should not be Null, Please Enter the First Name: ");
                    fn = Console.ReadLine();
                }

                Console.Write("Enter the Publisher name: ");
                string ln = Console.ReadLine();
                while (fn == null || fn == "" || fn == " ")
                {
                    Console.Write("Publisher Name Entered should not be Null, Please Enter the Publisher name: ");
                    ln = Console.ReadLine();
                }

                //Add book with Author
                Book1 book = new Book1();
                book.Name = fn;
                book.Publisher = ln;
                book.AuthorId = ID;//Convert.ToInt64(author1); //Id of the autheris important
                context.Book1s.Add(book);
                context.SaveChanges();

            }

            
        }
        public void insertAuthorAndBookBoth()
        {
            InsertInAuther();
            InsertInBook1();
        }
    }
}
