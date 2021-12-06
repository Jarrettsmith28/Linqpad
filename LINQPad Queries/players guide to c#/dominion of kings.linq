<Query Kind="Program" />

void Main()
{	
				int estate = 1;
				int duchy = 3;
				int province = 6;
				int estateCount = 0;
				int duchyCount = 0;
				int provinceCount = 0;
				Console.WriteLine("How many estates do you have?");
				string estateString = Console.ReadLine();
				Console.WriteLine("How many duchys do you have?");
				string duchyString = Console.ReadLine();
				Console.WriteLine("How many provinces do you have?");
				string provinceString = Console.ReadLine();
				if (int.TryParse(estateString, out int estateTry))
				{
					estateCount = estateTry;
				}
				if (int.TryParse(duchyString, out int duchyTry))
				{
					duchyCount = duchyTry;
				}
				if (int.TryParse(provinceString, out int provinceTry))
				{
					provinceCount = provinceTry;
				}
				int pointCount = estateCount * estate + duchyCount * duchy + provinceCount * province;
				Console.WriteLine("Your total points = " + pointCount);	
}

// Define other methods and classes here