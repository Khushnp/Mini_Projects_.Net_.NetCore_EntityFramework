using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_SSH.netConnection.SFTPConnection
{
    internal class SFTPConfig
    {
        public string host { get; set; }
        public int port { get; set; }
        public string username { get; set; }
        public string passphrase { get; set; }
        public string privateKeyLocalFilePath { get; set; }

        public SFTPConfig(string username)
        {
            this.host = "20.219.125.123";
            this.port = 22022;
            this.username = username;
            this.passphrase = "client";
            this.privateKeyLocalFilePath = @"C:\Users\kush.pachghare\source\repos\ConsoleApp6_SSH.netConnection\ConvertedPrivateKey";


        }
        
    }
}
