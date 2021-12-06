<Query Kind="Program" />

void Main()
{
	Console.WriteLine("How many chocolate eggs are there?");
	string numberOfEggs = Console.ReadLine();
	int eggs = Convert.ToInt32(numberOfEggs);
	int sisters = eggs/4;
	int duckbear = eggs%4;
	Console.WriteLine("Each sister gets " + sisters);
	Console.WriteLine("The duckbear gets " + duckbear);
	
}

// Define other methods and classes here