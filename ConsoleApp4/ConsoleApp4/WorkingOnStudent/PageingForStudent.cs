using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp4.WorkingOnStudent
{
    internal class PageingForStudent
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void Pageing()
        {
            
            //Console.Write("Enter the Records you want to display on one page: ");
            int RecordsPerPage = 10; //Convert.ToInt16(Console.ReadLine());
            //Console.Write("Enter the Records you want to display on one page: ");
            int PageNumber = 0;
            Console.WriteLine("We have 2000 Enteries in our Dataset On Each page 10 entries will be shown. ");
            do
            {
                Console.Write("Enter the Page Number between 1 and 200 : ");
                if (int.TryParse(Console.ReadLine(), out PageNumber))                //this will get the pageNumber if user enters int only else it will go to else and dowhile will repeat the cycle
                {
                    if (PageNumber > 0 && PageNumber <= 200)
                    {
                        var student = context.Students.Skip((PageNumber-1) * RecordsPerPage)
                                    .Take(RecordsPerPage).ToList();
                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        Console.WriteLine("Id " + "  |  " + "FirstName" + "  |  " + "LastName" + "  |  " + "RollNo" + "   |  ");
                        foreach ( var std in student)
                        {
                            Console.WriteLine(std.StudentId+"  |  "+std.FirstName+"  |  "+ std.LastName+"  |  "+std.RollNo+"   |  " );
                        }
                        Console.WriteLine();
                        Console.WriteLine("Enter 1 for Continue showing pages and 0 for stopping the Application: ");
                        if (Convert.ToInt16(Console.ReadLine()) == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Page Number");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Page Number");
                }
            } while (true);
        }

    }
}
