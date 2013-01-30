using System;
using System.Collections.Generic;

public class Alternative
{
	public const String SEPARATOR = "|";

	private IList<Symbol> symbols = new List<Symbol>();
	public IList<Symbol> GetSymbols()
	{
		return symbols;
	}
	public void AddSymbol(Symbol symbol)
	{
		symbols.Add(symbol);
	}
	
	public override String ToString()
	{
		String alternativeString = "";
		foreach (Symbol s in symbols)
		{
			alternativeString += " " + s;
		}
		
		if (alternativeString.Length == 0) {
			alternativeString = "epsilon";
		}
		
		return alternativeString;
	}
}