using System;
using System.Collections.Generic;

public class Experiment
{	
	private String name;
	public String Name
	{
		get { return this.name; }
		set { this.name = value; }
	}
	
	private IList<Ingredient> ingredients = new List<Ingredient>();
	public IList<Ingredient> GetIngredients()
	{
		return ingredients;
	}
	public void AddIngredient(Ingredient ingredient)
	{
		ingredients.Add(ingredient);
	}
		
	public override String ToString()
	{
		String returnString = "Experiment: " + name + "\n";
		
		foreach (Ingredient ingredient in ingredients) {
			returnString += "    "  + ingredient + "\n";
		}
		
		return returnString;
	}
}