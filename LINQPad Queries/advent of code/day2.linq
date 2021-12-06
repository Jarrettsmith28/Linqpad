<Query Kind="Program" />

public class Program
{

	public static void Main(string[] args)
	{
		int total = 0;
		int[] lwh = new int[3];
		string[] readText = File.ReadLines("C:\\Users\\jarretts\\Downloads\\input.txt").ToArray();
		Console.WriteLine(readText);
		for (int i = 0; i < readText.Length; i++)
		{
			int feetRibbon = DayTwo(readText[i]);
			total += feetRibbon;
			Console.WriteLine(feetRibbon);
			Console.WriteLine(total);
		}
		Console.WriteLine(total);
	}
	private static int DayTwo(string line)
	{
		var split = line.Split('x');
		int l = Convert.ToInt32(split[0]);
		int w = Convert.ToInt32(split[1]);
		int h = Convert.ToInt32(split[2]);
		int[] areas = new int[3];
		int[] perimiters = new int[3];
		areas[0] = l * w;
		areas[1] = w * h;
		areas[2] = h * l;
		perimiters[0] = l * 2 + w * 2;
		perimiters[1] = w * 2 + h * 2;
		perimiters[2] = l * 2 + h * 2;
		
		int sideA = 2 * areas[0] + 2 * areas[1] + 2 * areas[2] + areas.Min();
		int sideB = perimiters.Min() + l * w * h;
		return sideB;
	}
}