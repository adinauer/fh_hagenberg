using System;
using System.Collections.Generic;

public class SymbolNameGenerator
{
	private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private readonly Random rng = new Random();
	private ISet<String> usedSymbolNames = new HashSet<String>();

	public String Generate()
	{		
		return GetUnusedSymbolName();
	}
	
	private String GetUnusedSymbolName()
	{
		String symbolName = "";
		
		do {
			symbolName = GetRandomSymbolName();
		} while (usedSymbolNames.Contains(symbolName));
		
		usedSymbolNames.Add(symbolName);
		
		return symbolName;
	}
	
	private String GetRandomSymbolName()
	{
		String symbolName = "";

		for (int i = 0; i < 3; i++)
		{
			symbolName += CHARS[rng.Next(CHARS.Length)];
		}
		
		return symbolName;
	}
}