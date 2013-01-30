using System.Collections.Generic;

public class ExperimentMetrics
{
	private IList<Experiment> experiments;

	public ExperimentMetrics(IList<Experiment> experiments)
	{
		this.experiments = experiments;
	}
	
	public int GetNumberOfExperiments()
	{
		return experiments.Count;
	}
	
	public IList<Ingredient> GetIngredientsTotalUsed()
	{
		IList<Ingredient> ingredientsTotalUsed = new List<Ingredient>();
	
		foreach (Experiment e in experiments) {
			foreach (Ingredient i in e.GetIngredients()) {
				bool found = false;
				foreach (Ingredient ingredientInList in ingredientsTotalUsed) {
					if (i.Name == ingredientInList.Name) {
						ingredientInList.AmountInMl += i.AmountInMl;
						found = true;
					}
				}
				
				if (!found) {
					ingredientsTotalUsed.Add(new Ingredient(i.Name, i.AmountInMl));
				}
			}
		}
		
		return ingredientsTotalUsed;
	}
	
	public IList<Ingredient> GetIngredientsAverageUsed()
	{
		IList<Ingredient> ingredientsAverageUsed = GetIngredientsTotalUsed();
		int numberOfExperiments = GetNumberOfExperiments();
	
		foreach (Ingredient i in ingredientsAverageUsed) {
			i.AmountInMl = i.AmountInMl / numberOfExperiments;
		}
		
		return ingredientsAverageUsed;
	}
}