// See https://aka.ms/new-console-template for more information
using ConsoleApp3.CrudRelaMulOper;

Console.WriteLine("Hello, World!");

DisplayRealMulOpe dis = new DisplayRealMulOpe();
dis.displayall();
Console.WriteLine("NO. Of Authors Present are: "+ dis.numberOfRecordsInAuther());
Console.WriteLine("NO. Of Books Present are: " + dis.numberOfRecordsInBook());


InsertRelaMulOper insert = new InsertRelaMulOper();
//insert.InsertInAuther();
//insert.InsertInBook1();
//insert.insertAuthorAndBookBoth();

//dis.displayall();

DeleteRelaMulOpe delete= new DeleteRelaMulOpe();
//delete.DeleteMulBook();
//delete.DelAuthHavingBook();

//dis.displayall();


UpdateRelaMultOper update = new UpdateRelaMultOper();
//update.updateBook();
//update.UpdateAuthor();

//dis.displayall();



