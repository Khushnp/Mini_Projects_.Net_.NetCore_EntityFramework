using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CrudInRelationalDatabse
{
    internal class DeleteRelational
    {
        TrainingDb2Context context = new TrainingDb2Context();  
        public void deleteRelational() 
        {
            // This for deleting the book record (only), that can be done because forgein key exists in book not in the author hence 
            // deleting the author will create the problem as it will require us to delete his book first before deleting the author himself


            /* Book1 book = context.Book1s.Find(Convert.ToInt64(8)); //here we are deleting the book only. (which can be done easily)
             context.Book1s.RemoveRange(book);
             context.SaveChanges();*/

            //Deleting author who has books in the book table

            Author1 delauth = new Author1();                                                 // here object is created of Author1
            delauth = context.Author1s.Find(Convert.ToInt64(41));                            // here we are storing the data from the database in to the delauth object
            context.Book1s.RemoveRange(context.Book1s.Where(x => x.AuthorId == delauth.Id)); //now we need to delet books first from the book1 table related to the delauth author
            context.Author1s.Remove(delauth);                                                //now deleting the the author.
            
            
            context.SaveChanges();





        }
    }
}
