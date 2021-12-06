<Query Kind="Statements" />

var instructions = File.ReadAllText("C:/Users/jarretts/Documents/day3.txt");
int x = 0;
int y = 0;
var hash = new HashSet<Tuple<int, int>>();
hash.Add(Tuple.Create(0, 0));
foreach (var character in instructions)
{
	if (character == '^')
	{
		y++;
	}
	if (character == 'v')
	{
		y--;
	}
	if (character == '<')
	{
		x--;
	}
	if (character == '>')
	{
		x++;
	}
	hash.Add(Tuple.Create(x, y));
}
Console.WriteLine(hash.Count);

public class Santa
{
	
}