using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;


namespace ConsoleApp6_SSH.netConnection.SFTPConnection
{
    internal class SFTPConnection
    {

        public void SFTP_Connect(string Username)
        {
            var host = "20.219.125.123";
            var port = 22022;
            var username = Username;
            var passphrase = "client";
            var privateKeyLocalFilePath = @"C:\Users\kush.pachghare\source\repos\ConsoleApp6_SSH.netConnection\ConvertedPrivateKey";

            var remoteFolderPath = "/";
            //var localFolderPath = @"";


            var key = File.ReadAllText(privateKeyLocalFilePath);
            var buf = new MemoryStream(Encoding.UTF8.GetBytes(key));
            var PrivateKeyFile = new PrivateKeyFile(buf, passphrase);

            var connectionInfo = new ConnectionInfo(host, port, username,
                new PrivateKeyAuthenticationMethod(username, PrivateKeyFile));


            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();
                    var files = client.ListDirectory(remoteFolderPath);
                    Console.WriteLine("Connected --> " + username);
                    foreach (var file in files)
                    {
                        /*var localFolferPath = Path.Combine(@"D:\WorkSpace\Data", username);

                        if (!Directory.Exists(localFolferPath))
                            Directory.CreateDirectory(localFolferPath);*/

                        Console.WriteLine(file.FullName + " ");

                        /*if (file.Name != "." && file.Name != "..")
                        {
                            using (var targetFile = new FileStream(Path.Combine(localFolferPath, file.Name), FileMode.Create))
                            {
                                client.DownloadFile(file.FullName, targetFile);
                                targetFile.Close();
                            }
                        }*/
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} --Error --{1}", username, ex.Message);
                }
                finally
                {
                    client.Disconnect();
                    Console.WriteLine("Disconnected to " + username);
                }

            }

        }
    }
}



















/*//Paralel ForEach loop
var options = new ParallelOptions { MaxDegreeOfParallelism = 6 };

Parallel.ForEach(files, options, file =>
{
    Console.WriteLine("Conneted to --> " + file.FullName + " no. of threads used--> " + Thread.CurrentThread.ManagedThreadId);
});*/