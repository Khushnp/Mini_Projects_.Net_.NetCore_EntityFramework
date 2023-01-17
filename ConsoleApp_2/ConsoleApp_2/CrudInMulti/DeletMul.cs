using ConsoleApp_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2.CrudInMulti
{
    internal class DeletMul : UpdatMul
    {
        TrainingDB2Context context = new TrainingDB2Context();

        public void deletMul()
        {
            int count = numberOfRecords(); // method present in the Updatemul Class
            if(count > 0)
            {
                Console.Write("Enter the number of records you want to Delete: ");
                int num = Convert.ToInt32(Console.ReadLine());
                while(num > count)
                {
                    Console.Write("Number of records present are " + count + " So Please enter valid or less than " + count + " :  ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < num; i++)
                {
                    Console.Write("Enter the Id of records you want to Delete: ");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    //Deleting the record using specific id 
                    context.Author1s.RemoveRange(context.Author1s.Where(x => x.Id == ID));
                    Console.WriteLine("Record with the Id: " + ID + " is Removed");
                }
                context.SaveChanges();
            }
            else{
                Console.WriteLine("No data is present to Delete");
            }

        }

        /*public void DeletinRange()
        {
            Console.Write("Enter the Total number of records you want to Delete: ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<Author1> alist = context.Author1s.Take(size).ToList();
            context.Author1s.RemoveRange(alist);
            context.SaveChanges();

        }*/


    }
}
