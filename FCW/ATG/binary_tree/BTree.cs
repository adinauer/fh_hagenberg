using System;

public class BTree
{
	private bool assigned = false;
	public bool HasBeenAssigned()
	{
		return assigned;
	}

	private int value;
	public int Value
	{
		set
		{
			this.value = value;
			this.assigned = true;
		}
		get { return value; }
	}
	
	private BTree left;
	public BTree Left
	{
		set { this.left = value; }
		get { return left; }
	}
	
	private BTree right;
	public BTree Right
	{
		set { this.right = value; }
		get { return right; }
	}
	
	public override String ToString()
	{
		String leftString = left != null && left.HasBeenAssigned() ? left.ToString() : "";
		String rightString = right != null && right.HasBeenAssigned() ? right.ToString() : "";
		return " (" + leftString + ") " + value + " (" + rightString + ") ";
	}
}