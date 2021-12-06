<Query Kind="Program" />

void Main()
{
	Console.WriteLine("What is the length of the base of the triangle?");
	string triangleBaseString = Console.ReadLine();
	Console.WriteLine("What is the height of the triangle?");
	string triangleHeightString = Console.ReadLine();
	double triangleArea = 0;
	double triangleBase = Convert.ToDouble(triangleBaseString);
	double triangleHeight = Convert.ToDouble(triangleHeightString);
	
	triangleArea = triangleBase * triangleHeight / 2;
	
	Console.WriteLine("The area of the triangle is " + triangleArea);
}

// Define other methods and classes here