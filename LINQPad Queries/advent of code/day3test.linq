<Query Kind="Program">
  <Namespace>static UserQuery</Namespace>
</Query>

void Main()
{
	string input = "C:/Users/jarretts/Documents/day3.txt";
	char[] parsedInput = input.ToCharArray();
	//parsedInput.Take(10).Dump();    //(string str, int num) tup = ("part one", 5);    //tup.str.Dump();    //tup.num.Dump();    var santaTracker = new SantaTracker();
	foreach (var c in parsedInput)
	{
		SantaTracker.Go(c);
	}
	santaTracker.GetHouseCount().Dump("Part 1");
	santaTracker = new SantaTracker();
	var roboSantaTracker = new SantaTracker();
	for (int i = 0; i < parsedInput.Length - 1; i += 2)
	{
		santaTracker.Go(parsedInput[i]);
		roboSantaTracker.Go(parsedInput[i + 1]);
	}
	roboSantaTracker.GetHouseCount().Dump("RoboSanta");
	santaTracker.GetHouseCount().Dump("Santa");
	roboSantaTracker.houses.Union(santaTracker.houses).Count().Dump("combined");
}
public class SantaTracker
{
	public (int x, int y) currentPosition;
	public HashSet<(int x, int y)> houses;
    public SantaTracker()
    {
        this.currentPosition = (0, 0);
        this.houses = new HashSet<(int, int)>();
        this.houses.Add(this.currentPosition);
	}
	public int GetHouseCount()
	{
		return this.houses.Count();
	}
	public void Go(char direction)
	{
		switch (direction)
		{
			case 'v':
				this.Down();
				break;
			case '^':
				this.Up();
				break;
			case '<':
				this.Left();
				break;
			case '>':
				this.Right();
				break;
			default:
				break;
		}
	}
	public void Up()
	{
		this.currentPosition = (this.currentPosition.Item1, this.currentPosition.Item2 + 1);
		this.houses.Add(this.currentPosition);
	}
	public void Down()
	{
		this.currentPosition = (this.currentPosition.Item1, this.currentPosition.Item2 - 1);
		this.houses.Add(this.currentPosition);
	}
	public void Left()
	{
		this.currentPosition = (this.currentPosition.Item1 - 1, this.currentPosition.Item2);
		this.houses.Add(this.currentPosition);
	}
	public void Right()
	{
		this.currentPosition = (this.currentPosition.Item1 + 1, this.currentPosition.Item2);
		this.houses.Add(this.currentPosition);
	}
}