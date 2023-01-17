// See https://aka.ms/new-console-template for more information
using ConsoleApp_2;
using ConsoleApp_2.CrudInMulti;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

DisplayRecords display = new DisplayRecords();

/*display.DisplayAllRecords();
Console.WriteLine();*/

//Inserting Multiple Records---------------------------------->
/*InsertMul insertmul = new InsertMul();

insertmul.insertmul();
Console.WriteLine();

display.DisplayAllRecords();
Console.WriteLine();*/


//Deleting the multiple records ------------------------------->

DeletMul delobj = new DeletMul();

//Deletes only the records that we want

/*delobj.deletMul();
Console.WriteLine();

display.DisplayAllRecords();
Console.WriteLine();

//Randomly deletes any records
delobj.DeletinRange();
Console.WriteLine();*/


//Updating multiple records --------------------------------------->

UpdatMul updatMul = new UpdatMul();
/*updatMul.updateMul();

Console.WriteLine();

display.DisplayAllRecords();
*/
/*Console.WriteLine("Enter 1 for updateing the records.");
Console.WriteLine("Enter 0 for Displaying all the records.");
Console.WriteLine("For Exit : Tyoe any other number ---->  ");*/
int cmd = 1;

while(cmd != 0)
{
    
    Console.WriteLine("Enter 1 for Displaying all the records.");
    Console.WriteLine("Enter 2 for updateing the records.");
    Console.WriteLine("Enter 3 for Deleting multiple records.");

    Console.WriteLine("For Exit : Enter any other number ---->  ");
    cmd = Convert.ToInt32(Console.ReadLine());
    switch (cmd)
    {
        case 1:
            Console.WriteLine();
            display.DisplayAllRecords();
            break;

        case 2:
            Console.WriteLine();
            updatMul.updateMul();
            break;

        case 3:
            Console.WriteLine();
            delobj.deletMul();
            break;
            
        default:
            Console.WriteLine("Thank you for using The Console App");
            break;
    }

}

