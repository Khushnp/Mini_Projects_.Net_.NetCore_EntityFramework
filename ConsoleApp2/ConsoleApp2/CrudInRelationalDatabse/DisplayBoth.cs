using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CrudInRelationalDatabse
{
    internal class DisplayBoth
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void displayBoth() 
        {
            var data = context.Author1s.ToList();
            Console.WriteLine("Author DataBase: \n");
            Console.WriteLine("Id" + "  |  " + "FirstName" + "  |  " + "LastName" + "  |  " + "Ipaddress\n");


            foreach (var item in data) 
            { 
                Console.WriteLine(item.Id+"  |  "+item.FirstName+ "  |  "+item.LastName+ "  |  "+item.Ipaddress);
            }

            var data1 = context.Book1s.ToList();
            Console.WriteLine("\n\nBooks DataBase: \n");
            Console.WriteLine("Id" + "  |  " + "AuthorId" + "  |  " + "Book Name" + "  |  " + "Publisher" + "  |  " + "Ipaddress\n");
            foreach (var item in data1)
            {
                Console.WriteLine(item.Id + "  |  " +item.AuthorId+"  |  " + item.Name + "  |  " + item.Publisher + "  |  " + item.Ipaddress);
            }

        }
    }
}
