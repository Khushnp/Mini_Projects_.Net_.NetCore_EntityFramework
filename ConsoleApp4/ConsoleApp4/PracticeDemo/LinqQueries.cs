using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.PracticeDemo
{
    internal class LinqQueries
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void linqQueries()
        {
            /*var sel = context.Author1s.ToList();
            var select = sel.Select(x => new { Name = "omkar" });
            foreach (var item in select)
            {
                Console.WriteLine(item.Name);
            }*/

        }
    }
}
