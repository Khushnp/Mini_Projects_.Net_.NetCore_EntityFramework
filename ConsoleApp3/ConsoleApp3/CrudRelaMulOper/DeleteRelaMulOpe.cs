using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CrudRelaMulOper
{
    internal class DeleteRelaMulOpe : DisplayRealMulOpe
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void DeleteMulBook()
        {
            int countBooks = numberOfRecordsInBook();
            if (countBooks > 0)
            {
                Console.Write("Enter the number of Books you want to Delete: ");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > countBooks)
                {
                    Console.Write("Number of records present are " + countBooks + " So Please enter valid or less than " + countBooks + " :  ");
                    num = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("As going forward ID of the records will be needed hence Database is Shown");
                displayall();
                for (int i = 0; i < num; i++)
                {
                    int ID = IdcheckinBook();
                    //Deleting the record using specific id 
                    context.Book1s.RemoveRange(context.Book1s.Where(x => x.Id == ID));
                    context.SaveChanges();
                    Console.WriteLine("Record with the Id: " + ID + " is Removed");
                }
                
            }
            else
            {
                Console.WriteLine("No data is present to Delete");
            }

        }

        public void DelAuthHavingBook()
        {
            int countAuthors = numberOfRecordsInAuther();

            if(countAuthors> 0)
            {
                Console.Write("Enter the number of Authors you want to Delete: ");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > countAuthors)
                {
                    Console.Write("Number of records present are " + countAuthors + " So Please enter valid or less than " + countAuthors + " :  ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.WriteLine("As going forward ID of the records will be needed hence Database is Shown");
                displayall();
                for(int i = 0; i < num; i++)
                {
                    int ID = IdcheckinAuther();

                    /* Author1 delauth = new Author1();                                                 // here object is created of Author1
                     delauth = context.Author1s.Find(Convert.ToInt64(ID));                            // here we are storing the data from the database in to the delauth object*/
                    //some queries can be written directly inside of () as they return null or founded value 
                    context.Book1s.RemoveRange(context.Book1s.Where(x => x.AuthorId == ID)); //now we need to delet books first from the book1 table related to the delauth author
                    context.Author1s.Remove(context.Author1s.Find(Convert.ToInt64(ID)));         //now deleting the the author.
                    Console.WriteLine("Auther with the ID " + ID + " and his books in the book table all are Deleted...");
                    context.SaveChanges();
                }

            }
            else
            {
                Console.WriteLine("No data is present to Delete");
            }
                        
        }
    }
}
