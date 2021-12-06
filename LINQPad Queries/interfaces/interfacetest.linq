<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.DependencyInjection</NuGetReference>
</Query>

class program
{
	void Main()
	{






		Console.WriteLine("please enter a number");
		string num1 = Console.ReadLine();
		Console.WriteLine("please enter a number");
		string num2 = Console.ReadLine();
		Console.WriteLine("what math do you want? +-*/?");
		string math = Console.ReadLine();
		int n1 = Convert.ToInt32(num1);
		int n2 = Convert.ToInt32(num2);
		switch (math)
		{
			case "+":
				Addition myAdd = new Addition();
				myAdd.AddNumber(n1, n2);
				break;
			case "-":
				Subtraction mySubtract = new Subtraction();
				mySubtract.SubtractNumber(n1, n2);
				break;
			case "*":

				Multiplication myMultiply = new Multiplication();
				myMultiply.MultiplyNumber(n1, n2);
				break;
			case "/":

				Division myDivide = new Division();
				myDivide.DivideNumber(n1, n2);
				break;
			default:
				break;
		}

	}
}
public interface PerformOperation
{
	void AddNumber(int num1, int num2);
	void SubtractNumber(int num1a, int num2a);
	void MultiplyNumber(int num1b, int num2b);
	void DivideNumber(int num1c, int num2c);


}

class Addition
{

	public void AddNumber(int num1, int num2)
	{
		int result = num1 + num2;
		Console.WriteLine(result);
	}

}


class Subtraction
{

	public void SubtractNumber(int num1a, int num2a)
	{
		int result = num1a - num2a;
		Console.WriteLine(result);
	}

}
class Multiplication
{

	public void MultiplyNumber(int num1b, int num2b)
	{
		int result = num1b * num2b;
		Console.WriteLine(result);
	}

}
class Division
{

	public void DivideNumber(int num1c, int num2c)
	{
		int result = num1c / num2c;
		Console.WriteLine(result);
	}

}