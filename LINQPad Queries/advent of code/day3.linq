<Query Kind="Program" />

void Main()
{
	int horizontalPosition = 0;
	int verticalPosition = 0;
	int verticalPositionRobo = 0;
	int horizontalPositionRobo = 0;
	int countUniqueDeliveries = 0;
	List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
	Tuple<int, int> position;
	Tuple<int, int> roboPosition;
	string dayThreeInput = File.ReadAllText("C:/Users/jarretts/Documents/day3.txt");
	dayThreeInput.ToCharArray();
	char[] dayThreeCharArray = dayThreeInput.ToCharArray();
	for (int i = 0; i < dayThreeCharArray.Length; i += 2)
	{
		if (dayThreeCharArray[i] == '^')
		{
			verticalPosition++;
		}
		if (dayThreeCharArray[i] == 'v')
		{
			verticalPosition--;
		}
		if (dayThreeCharArray[i] == '<')
		{
			horizontalPosition--;
		}
		if (dayThreeCharArray[i] == '>')
		{
			horizontalPosition++;
		}
		position = Tuple.Create(horizontalPosition, verticalPosition);

		if (!positions.Contains(position))
		{
			positions.Add(position);
		}

	}


	for (int j = 1; j < dayThreeCharArray.Length; j += 2)
	{
		if (dayThreeCharArray[j] == '^')
		{
			verticalPositionRobo++;
		}
		if (dayThreeCharArray[j] == 'v')
		{
			verticalPositionRobo--;
		}
		if (dayThreeCharArray[j] == '<')
		{
			horizontalPositionRobo--;
		}
		if (dayThreeCharArray[j] == '>')
		{
			horizontalPositionRobo++;
		}
		roboPosition = Tuple.Create(horizontalPositionRobo, verticalPositionRobo);
		if (!positions.Contains(roboPosition))
		{
			positions.Add(roboPosition);
		}

	}

	Console.WriteLine(positions.Count);

}

