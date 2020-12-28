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
        public static void ProgramDelimitation(string line)   
        {
            /*Regex rgxProgramDelimitation = new Regex(@"\B([.])");
            Regex rgxProgramBegin = new Regex(@"\b(?<word>)");
            //Regex rgxProgramEnd = new Regex(@"\b(?<end>)");
            //Regex rgxProgramOrg = new Regex(@"\b(?<org>)");

            MatchCollection matchesDot = rgxProgramDelimitation.Matches(line);
            MatchCollection matchesBegin = rgxProgramBegin.Matches(line);
          //MatchCollection matchesEnd = rgxProgramEnd.Matches(line);
          //MatchCollection matchesOrg = rgxProgramOrg.Matches(line);

            if(rgxProgramDelimitation.IsMatch(line))
            {
            }
            */
            string patBegin = @"\B([.])begin";
            Regex r = new Regex(patBegin);
            Match m = r.Match(line);
            int matchCount = 0;
            while (m.Success)
            {
                Console.WriteLine("Match" + (++matchCount));
                for (int i = 1; i <= 2; i++)
                {
                    Group g = m.Groups[i];
                    Console.WriteLine("Group" + i + "='" + g + "'");
                    CaptureCollection cc = g.Captures;
                    for (int j = 0; j < cc.Count; j++)
                    {
                        Capture c = cc[j];
                        System.Console.WriteLine("Capture" + j + "='" + c + "', Position=" + c.Index);
                    }
                }
                m = m.NextMatch();
            }
        }
    }
    //Console.WriteLine("{0} matches found in:\n {1}",matches.Count,line);

}
