using System;

public class Ingredient
{
	private int amountInMl;
	public int AmountInMl
	{
		get { return this.amountInMl; }
		set { this.amountInMl = value; }
	}
	
	private String name;
	public String Name
	{
		get { return this.name; }
		set { this.name = value; }
	}
	
	public Ingredient(string name, int amountInMl)
	{
		this.name = name;
		this.amountInMl = amountInMl;
	}
		
	public override String ToString()
	{
		return name + " " + amountInMl;
	}
}