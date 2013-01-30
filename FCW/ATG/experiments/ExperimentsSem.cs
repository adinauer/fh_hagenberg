// ExperimentsSem.cs                                              HDO, 2006-08-28
// -------------
// Semantic evaluator for table-driven top-down parsing.
// Generated by Coco-2 (PGT).
//=====================================|========================================

using System;
using System.Text;

using Lex = ExperimentsLex;
using Syn = ExperimentsSyn;

public class ExperimentsSem {


  public const String MODULENAME = "ExperimentsSem";

  public static void ExperimentsSemMethod(Utils.ModuleAction action, out String moduleName) {
  //-----------------------------------|----------------------------------------
    moduleName = MODULENAME;
    switch (action) {
      case Utils.ModuleAction.getModuleName:
        return;
      case Utils.ModuleAction.initModule:
        break;
      case Utils.ModuleAction.resetModule:
        break;
      case Utils.ModuleAction.cleanupModule:
        return;
    } // switch
  } // ExperimentsSemMethod


  // *** start of global SYN and SEM declarations from ATG ***
  
  private static int amount;
  	private static String name;
  	private static System.Collections.Generic.List<Experiment> experiments = new System.Collections.Generic.List<Experiment>();

  // *** end of global SYN and SEM declarations from ATG ***

  

  private static void NT_Experiments() {
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1:
          NT_Experiment();
          break;
        case 2:
          NT_Experiment();
          break;
        case 3: // SEM
          Console.WriteLine("Experiments: ");
          			foreach (Experiment e in experiments) {
          				Console.WriteLine(e);
          			}
          			
          			
          			ExperimentMetrics metrics = new ExperimentMetrics(experiments);
          			
          			Console.WriteLine("Number of Experiments: " + metrics.GetNumberOfExperiments());
          			
          			Console.WriteLine("Total Amount used per Ingredient:");
          			foreach (Ingredient ingredient in metrics.GetIngredientsTotalUsed()) {
          				Console.WriteLine("  " + ingredient);
          			}
          			
          			Console.WriteLine("Average Amount used per Ingredient:");
          			foreach (Ingredient ingredient in metrics.GetIngredientsAverageUsed()) {
          				Console.WriteLine("  " + ingredient);
          			}
          		
          break;
      } // switch
    } // for
  } // NT_Experiments

  private static void NT_Experiment() {
    Experiment e = new Experiment();
    		
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1:
          Lex.GETidentifierAttr(out name);
          break;
        case 2: // SEM
          e.Name = name;
          			experiments.Add(e);
          		
          break;
        case 3:
          NT_Ingredient(ref e);
          break;
        case 4:
          NT_Ingredient(ref e);
          break;
      } // switch
    } // for
  } // NT_Experiment

  private static void NT_Ingredient(ref Experiment exp) {
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1:
          Lex.GETidentifierAttr(out name);
          break;
        case 2:
          Lex.GETnumberAttr(out amount);
          break;
        case 3: // SEM
          exp.AddIngredient(new Ingredient(name, amount));
          		
          break;
      } // switch
    } // for
  } // NT_Ingredient


  public delegate void PragmaMethod();
  public static PragmaMethod[] pragmaMethods = {
      // none
    };


  public static void StartSem() {
  //-----------------------------------|----------------------------------------
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1:
          NT_Experiments();
          break;
      } // switch
    } // for
  } // StartSem

    
} // ExperimentsSem

// End of ExperimentsSem.cs
//=====================================|========================================