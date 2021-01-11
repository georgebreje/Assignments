using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ARC
{
    public class Decrypt
    {
        public static void ProgramComs(string line)
        {
            string patBegin = @"\.begin?";
            string patOrg = @"\.org 2048?";
            string patEnd = @"\.end?";
            Regex rB = new Regex(patBegin);
            Regex rO = new Regex(patOrg);
            Regex rE = new Regex(patEnd);


            Match matchBegin = rB.Match(line);
            Match matchOrg = rO.Match(line);
            Match matchEnd = rE.Match(line);

            char[] errCheck = new char[line.Length];
            int i = 0;
            foreach(char s in line)
            {
                if (s != ' ')
                    errCheck[i] = s;

                i++;
            }
            string checking = new string(errCheck);
            if (checking != ".begin" && checking != ".org 2048" && checking != ".end")
            {
                Console.WriteLine("Syntax error");
            }
            else
            {
                if (matchBegin.Success)
                {
                    Console.WriteLine(matchBegin.Value);
                }
                else if (matchOrg.Success)
                {
                    Console.WriteLine(matchOrg.Value);
                }
                else if (matchEnd.Success)
                {
                    Console.WriteLine(matchEnd.Value);
                }
            }
        }
    }

}
