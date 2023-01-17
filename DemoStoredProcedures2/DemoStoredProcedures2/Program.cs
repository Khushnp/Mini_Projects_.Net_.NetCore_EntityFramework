using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DemoStoredProcedures2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainingDB2Entities1 context = new TrainingDB2Entities1();
            //below code for the insertion as our table didn't contained Anything.
            /*try
            {

                StudentGrade student = new StudentGrade();
                student.CourseID = 3;
                student.Grade = 3;
                student.StudentID = 3;
                context.StudentGrades.Add(student);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                Console.WriteLine("....exception : " + ex.Message);
            }*/

            int studentID = 3;
            var studentGrades = context.GetStudentGrades(studentID);  //here stored procedure is called.

            foreach (var student in studentGrades)
            {
                Console.WriteLine("Course ID: {0}, student ID: {1}, Grade: {2} ",
                   student.CourseID, student.StudentID, student.Grade);
            }


            /*var author = context.get*/

            Console.ReadKey();

            






        }
    }
}
