<Query Kind="Program" />

internal class ProgramDay3Part2 //class
	{
		private static void Main()
		{
			var path = "C:/Users/jarretts/Documents/day3.txt";
			var allines = File.ReadAllText(path);

			var santa = new Santa(); //object of Santa
			var roboSanta = new RoboSanta(); //object of Santa

			var whoMove = true; // if true - Santa, if false then Robosanta 

			foreach (var c in allines)
			{
				var person = whoMove ? (IMove)santa : roboSanta; //??object of IMove??
				Position nextPosition = null; //object of position
				switch (c)
				{
					case '>':
						nextPosition = person.MoveRight(person.GetLastPosition());
						break;
					case '<':
						nextPosition = person.MoveLeft(person.GetLastPosition());
						break;
					case '^':
						nextPosition = person.MoveUp(person.GetLastPosition());
						break;
					case 'v':
						nextPosition = person.MoveDown(person.GetLastPosition());
						break;
				}
				person.AddPosition(nextPosition);
				whoMove = !whoMove;
			}

			var visitedHouses = santa.Track.Concat(roboSanta.Track).Distinct().ToList();

			Console.WriteLine("Together they visited " + visitedHouses.Count);
		}
	}

	internal class Position : IEquatable<Position> //class derived from System
	{
		public int X { get; set; } //field with get and set properties
		public int Y { get; set; } //field with get and set properties

		public Position(int x, int y) //method
		{
			X = x; 
			Y = y;
		}

		public override bool Equals(object obj) //method
		{
			return Equals(obj as Position);
		}

		public bool Equals(Position other) //method
		{
			if (other == null) return false;
			return X.Equals(other.X) && Y.Equals(other.Y);
		}

		public override int GetHashCode() //method
		{
			unchecked
			{
				return (X * 397) ^ Y;
			}
		}
	}

	internal interface IMove //interface IMove
	{
		Position MoveRight(Position position);
		Position MoveLeft(Position position);
		Position MoveUp(Position position);
		Position MoveDown(Position position);
		Position GetLastPosition();
		void AddPosition(Position position);
	}

	internal class FairyTaleCharacter : IMove //class named FairyTaleCharacter derived from IMove interface
	{
		public List<Position> Track { get; set; } //field

		public Position MoveRight(Position position) //method
		{
			var nextPosition = new Position(position.X + 1, position.Y);
			return nextPosition;
		}

		public Position MoveLeft(Position position) //method
		{
			var nextPosition = new Position(position.X - 1, position.Y);
			return nextPosition;
		}

		public Position MoveUp(Position position) //method
		{
			var nextPosition = new Position(position.X, position.Y + 1);
			return nextPosition;
		}

		public Position MoveDown(Position position) //method
		{
			var nextPosition = new Position(position.X, position.Y - 1);
			return nextPosition;
		}

		public Position GetLastPosition() //method
		{
			return Track.Last();
		}

		public void AddPosition(Position position)
		{
			if (Track.Any(p => p.X == position.X & p.Y == position.Y))
			{
				Track.RemoveAll(p => p.X == position.X & p.Y == position.Y);
			}

			Track.Add(position);
		}
	}

	internal class Santa : FairyTaleCharacter //class named Santa derived from FairyTaleCharacter
	{
		public Santa() //method in the RoboSanta class
		{
			Track = new List<Position> { new Position(0, 0) };
		}
	}

	internal class RoboSanta : FairyTaleCharacter //class named RoboSanta derived from FairyTaleCharacter
	{
		public RoboSanta() //method in the RoboSanta class
		{
			Track = new List<Position> { new Position(0, 0) };
		}
	}