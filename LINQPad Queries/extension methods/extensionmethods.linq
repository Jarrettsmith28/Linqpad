<Query Kind="Program">
  <Namespace>ExtensionMethods</Namespace>
</Query>

void Main()
{

	string s = "hello extension methods";
	int i = s.WordCount();
}



namespace ExtensionMethods
{
	public static class MyExtensions
	{
		public static int WordCount(this string str)
		{
			return str.Split(new char[] { ' ','.','?'},
			StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}