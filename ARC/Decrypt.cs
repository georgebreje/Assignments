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
            //string patErr = @"\w+\B([.,/;'[]\=-1234567890<>:";
            Regex rB = new Regex(patBegin);
            Regex rO = new Regex(patOrg);
            Regex rE = new Regex(patEnd);
            //Regex rErr = new Regex(patErr);


            Match matchBegin = rB.Match(line);
            Match matchOrg = rO.Match(line);
            Match matchEnd = rE.Match(line);
            //Match matchErr = rErr.Match(line);

            //if(matchErr.Success && (matchErr.Value!=matchBegin.Value))
            //{
            //    Console.WriteLine(matchErr.Value);
            //}
            if (matchBegin.Success)
            {
                Console.WriteLine("begin");
            }
            if (matchOrg.Success)
            {
                Console.WriteLine("org 2048");
            }
            if (matchEnd.Success)
            {
                Console.WriteLine("end");
            }
        }
    }

}
