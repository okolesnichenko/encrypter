using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5_encrypting_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("lab_5.txt", Encoding.Default);
            String line = sr.ReadToEnd();
            EncryptingRussianText a = new EncryptingRussianText(line);
            Console.Write(a.Encrypting());
            Console.ReadKey();
        }
    }
}
