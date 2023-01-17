using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.WorkingOnStudent
{
    internal class InsertMultipleIntoStudent
    {
        TrainingDb2Context context = new TrainingDb2Context();
        public void insertmany()
        {
            int i = 0, j = 0;
            for (j = 0; j < 1; j++)
            {
                Student student = new Student();
                student.FirstName = "FirstName";
                student.LastName = "LastName";
                student.RollNo = i + 10;
                student.Address = "Address";
                i++;
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
