using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ARC
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            StreamReader sr = new StreamReader(@"data.in");
            while ((line = sr.ReadLine()) != null)
            {
                Decrypt.ProgramDelimitation(line);
            }
        }

    }
}
