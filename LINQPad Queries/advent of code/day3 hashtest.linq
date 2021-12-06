<Query Kind="Statements" />

var input = File.ReadAllText("C:/Users/jarretts/Documents/day3.txt");
int[] x = new int[] { 0, 0 };
int[] y = new int[] { 0, 0 };
var hash = new HashSet<Tuple<int, int>>();
hash.Add(Tuple.Create(0, 0));
int i = 0;
foreach (var chr in input)
{
	x[i] += chr == '>' ? 1 : (chr == '<' ? -1 : 0);
	y[i] += chr == 'v' ? 1 : (chr == '^' ? -1 : 0);
	hash.Add(Tuple.Create(x[i], y[i]));
	i = 1 - i;
}
Console.WriteLine(hash.Count);