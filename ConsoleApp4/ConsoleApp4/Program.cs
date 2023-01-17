// See https://aka.ms/new-console-template for more information
using ConsoleApp4.PracticeDemo;
using ConsoleApp4.WorkingOnStudent;

Console.WriteLine("Hello, World!");

/*LinqQueries obj =  new LinqQueries();
obj.linqQueries();*/

/*List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
Console.WriteLine("Skip Method Working Shown Below: ");
//Skip Operator/Method skips the count we have entered and Take Operator/Method Takes in the count that we have entered.
List<int> list = (from item in numbers select item).Skip(5).Take(3).ToList();                   //Can also be done like------>> //List<int> list = numbers.Skip(10).ToList();
foreach (int item in list)
{
    Console.WriteLine(item);
}*/



/*InsertMultipleIntoStudent insert = new InsertMultipleIntoStudent();
insert.insertmany();*/

PageingForStudent pfs = new PageingForStudent();
pfs.Pageing();

