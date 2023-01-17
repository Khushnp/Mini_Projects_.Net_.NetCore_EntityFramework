using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CrudInRelationalDatabse
{
    internal class UpdateRelational
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void updateRelational()
        {
            /*var author = context.Author1s.FirstOrDefault(i=> i.Id == 13);             //----> for specific record modification of Author
            author.FirstName = "Test";
            author.LastName = "TestLAstNAme";
            author.Email = "kfgaekf@fajdgf.comn";
            Console.WriteLine("Author Record Modified");
            context.SaveChanges();*/


            var book = context.Book1s.First(f=> f.AuthorId == 13 );                     //----> Upadateing the Book Table using already present Auhor Id
            book.Publisher = "Test";
            book.Name= "Test";
            book.Isbn = 51232;
            Console.WriteLine("Book Databse is updated");
            context.SaveChanges();




        }
    }
}
