using System;
using System.Collections.Generic;

public class Rule
{
	private String nonTerminal;
	public String NonTerminal
	{
		get { return nonTerminal; }
		set { this.nonTerminal = value; }
	}
	
	private IList<Alternative> alternatives = new List<Alternative>();
	public IList<Alternative> GetAlternatives()
	{
		return alternatives;
	}
	public void AddAlternative(Alternative alternative)
	{
		alternatives.Add(alternative);
	}
	
	public override String ToString()
	{
		String alternativesString = "";
		bool isFirstAlternative =  true;
		
		foreach (Alternative a in alternatives) {
			if (!isFirstAlternative) {
				alternativesString += " " + Alternative.SEPARATOR;
			}
			alternativesString += a;
			isFirstAlternative = false;
		}
		return nonTerminal + " -> " + alternativesString;
	}
}