using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CrudInRelationalDatabse
{
    internal class InsertInReaLational
    {
        TrainingDb2Context context = new TrainingDb2Context();

        public void insert()
        {
            Author1 author = new Author1();
            author.FirstName = "Author2";
            author.LastName = "Author2Lastname";
            author.AddedDate = DateTime.Now;
            author.ModifiedDate = DateTime.Now;
            author.Ipaddress = 654321;

            context.Author1s.Add(author);
            context.SaveChanges();

            //inserting in the book1 table and if we want to insert in the book table only than we need to get the Author id from the database to insert in the book table

            Book1 book1 = new Book1();
            book1.AuthorId = author.Id;
            book1.AddedDate = DateTime.Now;
            book1.ModifiedDate = DateTime.Now;
            book1.Name = "Book1";
            book1.Publisher = "Auther1 Published Himself";  


            Book1 book2 = new Book1();
            book2.AuthorId = author.Id;
            book2.AddedDate = DateTime.Now;
            book2.ModifiedDate = DateTime.Now;
            book2.Name = "Book1";
            book2.Publisher = "Auther1 Published Himself";


            /* context.Book1s.Add(book1);
             context.SaveChanges();*/
            ///
            author.Book1s.Add(book1);
            author.Book1s.Add(book2);

//            context.Author1s.Add(author);

            context.SaveChanges();


            /*var book = new Book1 { Name = "King Lear" ,Publisher="publissher" };
            var author = context.Author1s.Find( Convert.ToInt64(37));          // inserting book at the specific aurhor using the Id of the author here it i hard coded as 41 
            // but can be inserted as per the need.
            author.Book1s.Add(book);
            context.SaveChanges();*/



        }
    }
}
