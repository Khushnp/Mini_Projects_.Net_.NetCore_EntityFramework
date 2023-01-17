using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CrudRelaMulOper
{
    internal class DisplayRealMulOpe
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void displayall()
        {
            var data = context.Author1s.ToList();
            Console.WriteLine("Author DataBase: \n");
            Console.WriteLine("Id" + "  |  " + "FirstName" + "  |  " + "LastName" + "  |  " + "Ipaddress\n");


            foreach (var item in data)
            {
                Console.WriteLine(item.Id + "  |  " + item.FirstName + "  |  " + item.LastName + "  |  " + item.Ipaddress);
            }

            var data1 = context.Book1s.ToList();
            Console.WriteLine("\n\nBooks DataBase: \n");
            Console.WriteLine("Id" + "  |  " + "AuthorId" + "  |  " + "Book Name" + "  |  " + "Publisher" + "  |  " + "Ipaddress\n");
            foreach (var item in data1)
            {
                Console.WriteLine(item.Id + "  |  " + item.AuthorId + "  |  " + item.Name + "  |  " + item.Publisher + "  |  " + item.Ipaddress);
            }
            Console.WriteLine();
        }

        public int numberOfRecordsInAuther()
        {
            //checking the number of records present in the database table
            //var records = context.Author1s.Count();
            return context.Author1s.Count();
        }


        public int numberOfRecordsInBook()
        {
            //checking the number of records present in the database table
            return context.Book1s.Count(); // All the below code can be done in count() functin
            
            /*var IDCHECK = context.Book1s.ToList();
         //var count = context.Author1s.Count(t => t.Id  == '1'); //this cannot be used as the starting of the id is unkown.
         int Bookcount = 0;
         foreach (var idcheck in IDCHECK)
         {
             Bookcount++;
         }*/
        }
        public int IdcheckinBook()
        {
            Console.Write("Enter the Id of the book: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var IDCHECK = context.Book1s.Find(Convert.ToInt64(ID));

            while (IDCHECK == null)
            {
                Console.Write("ID Entered is either Null or doestnot exist in database, Please Enter Correct ID: ");
                ID = Convert.ToInt32(Console.ReadLine());
                IDCHECK = context.Book1s.Find(Convert.ToInt64(ID));
            }

            return ID;
        }

        public int IdcheckinAuther()
        {
            Console.Write("Enter the Id of the Author: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var IDCHECK = context.Author1s.Find(Convert.ToInt64(ID));

            while (IDCHECK == null)
            {
                Console.Write("ID Entered is either Null or doestnot exist in database, Please Enter Correct ID: ");
                ID = Convert.ToInt32(Console.ReadLine());
                IDCHECK = context.Author1s.Find(Convert.ToInt64(ID));
            }

            return ID;
        }
    }
}
