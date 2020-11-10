using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti calea fisierului");
            string path = Console.ReadLine();
            char[] del = new char[] { ' ', '"' };
            path = path.Trim(del);
            int counter = 0;
            byte[] ba = new byte[16];
            int actual;
            FileStream file = new FileStream(path, FileMode.Open);
            while ((actual = file.Read(ba, 0, 16)) > 0)
            {
                string hex = BitConverter.ToString(ba);
                string text = null;
                for (int i = 0; i < actual; i++)
                {
                    if (ba[i] < ' ')
                        text+= ".";
                    else
                        text+= ((char)ba[i]).ToString() ;
                }    
                Console.WriteLine($"{counter:X8}: {hex} | {text}");
                counter++;
            }
        }
    }
}
