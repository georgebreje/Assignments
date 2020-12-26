using System;
using System.Text.RegularExpressions;

namespace Dexy
{
	public class Dex
	{
		public static void nume(string line)
		{
			string programDelimitationPattern = @"\b[.]\w+";
			Regex line = new Regex(programDelimitationPattern);
			matches = programDelimitation.Matches(programDelimitationPattern);
			for (int i = 0; i < matches.Count; i++)
				Console.WriteLine($"{matches[i].Value}");
		}
	}
}
