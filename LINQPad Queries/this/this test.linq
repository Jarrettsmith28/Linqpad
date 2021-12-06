<Query Kind="Program" />

void Main()
{
	
}

public static string GetSpecialMessage(int a)
{
	return "Special Message";
}
public static string GetCrazyMessage(this int a)
{
	return "Crazy message";
}
public static void TestCalling()
{
	int x = 61;
	x.GetCrazyMessage();
	GetCrazyMessage(x);
}