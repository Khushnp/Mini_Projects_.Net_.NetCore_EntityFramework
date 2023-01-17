using ConsoleApp_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2.CrudInMulti
{

    internal class InsertMul
    {
        TrainingDB2Context ctx = new TrainingDB2Context();
        public void insertmul()
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

            ctx.Author1s.AddRange(author1s);
            ctx.SaveChanges();
        }


        /*public void insertu()
        {
            //this is also the another way to add multiple records
            IList<Author1> newStudents = new List<Author1>()
            {
                    new Author1() { FirstName= "Steve" },
                    new Author1() { FirstName = "Bill" },
                    new Author1() { FirstName = "James" },
            };
            ctx.Author1s.AddRange(newStudents);
            ctx.SaveChanges();

        }*/

        /*public void Ddisplay()
        {
            var data = ctx.Author1s.ToList();
            foreach (var author1 in data)
            {
                Console.WriteLine(author1.Id + " " + author1.FirstName + " " + author1.LastName);
            }

        }*/


    }
}
