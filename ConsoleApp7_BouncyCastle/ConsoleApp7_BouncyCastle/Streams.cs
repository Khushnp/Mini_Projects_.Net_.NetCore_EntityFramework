using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_BouncyCastle
{
    public class Streams
    {
        private const int BufferSize = 512;

        public static void PipeAll(Stream inStr, Stream outStr)
        {
            byte[] bs = new byte[BufferSize];
            int numRead;
            while ((numRead = inStr.Read(bs, 0, bs.Length)) > 0)
            {
                outStr.Write(bs, 0, numRead);
            }
        }
    }
}
