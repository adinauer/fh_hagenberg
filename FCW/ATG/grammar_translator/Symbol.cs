using System;

public class Symbol
{
	public enum Kind
	{
		TERMINAL,
		NONTERMINAL
	}

	private String name;
	private Kind kind;
	
	public Symbol (String name, Kind kind)
	{
		this.name = name;
		this.kind = kind;
	}
	
	public override String ToString()
	{
		return name;
	}
}