using ConsoleApp_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2.CrudInMulti
{
    internal class UpdatMul
    {
        TrainingDB2Context context = new TrainingDB2Context();
        public int numberOfRecords()
        {
            //checking the number of records present in the database table
            var IDCHECK = context.Author1s.ToList();
            //var count = context.Author1s.Count(t => t.Id  == '1'); //this cannot be used as the starting of the id is unkown.
            int count = 0;
            foreach (var idcheck in IDCHECK)
            {
                count++;
            }
            //context.SaveChanges();
            return count;
        } 

        public void updateMul()
        {
            List<Author1> author1s = new List<Author1>();

            /*author1s.Add(new Author1 { Id = 13, FirstName = "Khush", LastName = "Pachghare" });
            author1s.Add(new Author1 { Id = 24, FirstName = "Jay", LastName = "Gates" });
            foreach (var item in author1s)
            {
                var authi = context.Author1s.Where(f => f.Id == item.Id).FirstOrDefault();
                //var dept = db.Departments.Where(f => f.DepartmentID == item.DepartmentID).FirstOrDefault();
                if (authi == null) throw new Exception("");
                authi.FirstName = item.FirstName;
                authi.LastName = item.LastName;
            }
            context.SaveChanges();*/

            
            int count =numberOfRecords();
            if(count > 0)
            {
                //Taking input
                Console.Write("Enter the number of records you want to Update: ");
                int s = Convert.ToInt32(Console.ReadLine());
                while (s > count)
                {
                    Console.Write("Number of records present are "+count+" So Please enter valid or less than "+count+" :  ");
                    s = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < s; i++)
                {

                    Console.Write("Enter the Id of records you want to update: ");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    
                    var IDCHECK = context.Author1s.ToList();
                    int flags = 0;
                    foreach (var idcheck in IDCHECK)
                    {
                        if (idcheck.Id == ID)
                        {
                            flags = ID;
                            break;
                        }
                    }
                    
                    while (ID == 0 || flags == 0)
                    {
                        Console.Write("ID Entered is either Null or doestnot exist in database, Please Enter Correct ID: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        foreach (var idcheck in IDCHECK)
                        {
                            if (idcheck.Id == ID)
                            {
                                flags = ID;
                                break;
                            }
                        }
                    }
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

                    author1s.Add(new Author1 { Id = ID, FirstName = fn, LastName = ln }); //Update query working here
                    Console.WriteLine();
                    context.SaveChanges();
                }
                ///context.SaveChanges();
                foreach (var item in author1s)
                {
                    var authid = context.Author1s.Where(f => f.Id == item.Id).FirstOrDefault();
                    if (authid == null)
                    {
                        throw new Exception("ID is NULL ");
                    }
                    authid.FirstName = item.FirstName;
                    authid.LastName = item.LastName;
                    authid.Email = item.Email;
                    authid.Ipaddress = item.Ipaddress;
                    context.SaveChanges();
                }
               // context.SaveChanges();
            }
            else
            {
                Console.WriteLine("No data is present to update");
            }
        }
    }
}
