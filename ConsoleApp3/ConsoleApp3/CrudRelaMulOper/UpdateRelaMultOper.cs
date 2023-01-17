using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CrudRelaMulOper
{
    internal class UpdateRelaMultOper : DisplayRealMulOpe
    {
        TrainingDb2Context context = new TrainingDb2Context();
               

        public void updateBook()
        {
            int countBooks = numberOfRecordsInBook();
            if(countBooks > 0)
            {
                Console.Write("Enter the number of books you want to update: ");
                int size = Convert.ToInt32(Console.ReadLine());
                while (size > countBooks)
                {
                    Console.Write("Number of records present are " + countBooks + " So Please enter valid or less than " + countBooks + " :  ");
                    size = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < size; i++)
                {
                    int ID = IdcheckinBook();
                    Console.WriteLine("Got the Id : " + ID);
                    Console.Write("Enter the name of the Book: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the name of the publisher: ");
                    string publisher = Console.ReadLine();

                    var book = context.Book1s.First(f => f.Id == ID);                     //----> Upadateing the Book Table using already present Auhor Id
                    book.Publisher = publisher;
                    book.Name = name;
                    Console.WriteLine("Book Databse is updated");
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("NO Data Found");
            }

        }

        public void UpdateAuthor()
        {
            //List<Author1> author1s = new List<Author1>();
            int count = numberOfRecordsInAuther();
            if (count > 0)
            {
                //Taking input
                Console.Write("Enter the number of records you want to Update: ");
                int s = Convert.ToInt32(Console.ReadLine());
                while (s > count)
                {
                    Console.Write("Number of records present are " + count + " So Please enter valid or less than " + count + " :  ");
                    s = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < s; i++)
                {
                    int ID = IdcheckinAuther();   //checking Id if it is corrrect or not 
                    Console.Write("Enter the Firstname: ");
                    string fn = Console.ReadLine();

                    //First name may be Null Condition Handling
                    while (fn == null || fn == "" || fn == " ")
                    {
                        Console.Write("First Name Entered should not be Null, Please Enter the First Name: ");
                        fn = Console.ReadLine();
                    }

                    Console.Write("Enter the Lastname: ");
                    string ln = Console.ReadLine();

                    var record = context.Author1s.Find(Convert.ToInt64(ID));
                    record.FirstName = fn;
                    record.LastName = ln;
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("No data is present to update");
            }
        }
    }
}
