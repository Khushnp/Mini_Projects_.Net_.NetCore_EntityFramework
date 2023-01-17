using ConsoleApp_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2.CrudInMulti
{
    internal class DisplayRecords
    {
        TrainingDB2Context context = new TrainingDB2Context();  
        public void DisplayAllRecords()
        {
           
            var data = context.Author1s.ToList();
            foreach (var record in data) 
            {
                Console.WriteLine(" "+record.Id+" "+ record.FirstName+" "+ record.LastName+" ");
            }
        }
    }
}
