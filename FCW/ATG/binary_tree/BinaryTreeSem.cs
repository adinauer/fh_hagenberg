// BinaryTreeSem.cs                                              HDO, 2006-08-28
// -------------
// Semantic evaluator for table-driven top-down parsing.
// Generated by Coco-2 (PGT).
//=====================================|========================================

using System;
using System.Text;

using Lex = BinaryTreeLex;
using Syn = BinaryTreeSyn;

public class BinaryTreeSem {


  public const String MODULENAME = "BinaryTreeSem";

  public static void BinaryTreeSemMethod(Utils.ModuleAction action, out String moduleName) {
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
  } // BinaryTreeSemMethod


  // *** start of global SYN and SEM declarations from ATG ***
  
  private static int num;
  	private static BTree tree;

  // *** end of global SYN and SEM declarations from ATG ***

  

  private static void NT_BinaryTree() {
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1: // SEM
          tree = new BTree();
          		
          break;
        case 2:
          NT_SubTree(ref tree);
          break;
        case 3: // SEM
          Console.WriteLine("Tree:");
          			Console.Write("(");
          			if (tree.HasBeenAssigned()) {
          				Console.Write(tree);
          			}
          			Console.WriteLine(")");
          		
          break;
      } // switch
    } // for
  } // NT_BinaryTree

  private static void NT_SubTree(ref BTree t) {
    BTree left = new BTree();
    			BTree right = new BTree();
    		
    for (;;) {
      switch (Syn.Interpret()) {
        case 0:
          return;
        case 1:
          NT_SubTree(ref left);
          break;
        case 2:
          Lex.GETnumberAttr(out num);
          break;
        case 3: // SEM
          t.Value = num;
          					t.Left = left;
          					t.Right = right;
          				
          break;
        case 4:
          NT_SubTree(ref right);
          break;
      } // switch
    } // for
  } // NT_SubTree


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
          NT_BinaryTree();
          break;
      } // switch
    } // for
  } // StartSem

    
} // BinaryTreeSem

// End of BinaryTreeSem.cs
//=====================================|========================================