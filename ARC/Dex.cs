using System;
using System.Text.RegularExpressions;

public class Dex
{
	public Dex()
	{
		string programDelimitationPattern = @"\b[.]\w+";
		Regex line = new Regex(programDelimitationPattern);
		matches = programDelimitation.Matches(programDelimitationPattern);
		for (int i = 0; i < matches.Count; i++)
			Console.WriteLine($"{matches[i].Value}");
	}
}
