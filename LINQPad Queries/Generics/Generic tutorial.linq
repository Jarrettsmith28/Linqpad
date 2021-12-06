<Query Kind="Program" />

	public class ClsMain
	{
		private static void Main()
		{
			//bool IsEqual = ClsCalculator.AreEqual(20,20);
			//bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
			bool IsEqual = ClsCalculator.AreEqual<double>(20,10);
			
			if (IsEqual)
			{
				Console.WriteLine("Both are Equal");
			
			}
			else
			{
				Console.WriteLine("Both are Not Equal");
			
			}

		}

		public class ClsCalculator
		{
			public static bool AreEqual<T>(T value1, T value2)
			{
				return value1.Equals(value2);
			}
			
			
	}
	}