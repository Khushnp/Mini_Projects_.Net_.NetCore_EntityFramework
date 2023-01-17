// See https://aka.ms/new-console-template for more information
using ConsoleApp6_SSH.netConnection.SFTPConnection;
using Renci.SshNet;
Console.WriteLine("Hello, World!");



/*MultipleRemoteOperations obje = new MultipleRemoteOperations();
obje.multiRemoteOperations();*/

List<string> usernames = System.IO.File.ReadAllLines(@"C:\Users\kush.pachghare\source\repos\ConsoleApp6_SSH.netConnection\ConsoleApp6_SSH.netConnection\SFTPConnection\Usernames.txt").ToList();
Parallel.ForEach(usernames, usernameLine =>
{
    Console.WriteLine("Connecting to " + usernameLine);
    SFTPConnection obj = new SFTPConnection();
    obj.SFTP_Connect(usernameLine);
});



