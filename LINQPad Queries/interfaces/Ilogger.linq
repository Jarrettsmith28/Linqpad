<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.DependencyInjection</NuGetReference>
  <Namespace>Microsoft.Extensions.DependencyInjection</Namespace>
</Query>

void Main()
{
	IServiceCollection sc = new ServiceCollection();
	sc.AddTransient<IOperate, Add>();
	sc.AddTransient<IOperate, Sub>();
	sc.AddTransient<IOperate, Mod>();
	sc.AddTransient<IOperate, Div>();
	sc.AddTransient<IOperate, Prod>();
	sc.AddTransient<ILogger, Logger>();
	//sc.AddTransient<IFactory, Factory>();
	IServiceProvider serviceProvider = sc.BuildServiceProvider();
	IEnumerable<IOperate> operators = serviceProvider.GetService<IEnumerable<IOperate>>();
	int left = Convert.ToInt16(Util.ReadLine("Enter your first number"));
	int right = Convert.ToInt16(Util.ReadLine("Enter your second number"));
	char op = Convert.ToChar(Util.ReadLine("Enter your operator"));
	IOperate operatorInstance = null;
	foreach (var o in operators)
		{
			if (o.Operand == op)
			{
				operatorInstance = o;
				break;
			}
		}
		if (operatorInstance is null)
		{
		"Cannot find operator instance for your operation.".Dump();
			return;
		}
		int result = operatorInstance.Func(left, right);
		result.Dump("Operation result");
}
public class Add : IOperate
{
	private ILogger logger;
	public Add(ILogger AddLog)
	{
		
		this.logger = AddLog;
		
	}
	
	public char Operand { get { return '+'; } }
	public int Func(int l, int r)
	
	{
		this.logger.LoggerMethod($"Calling Add with {l} and {r}.");
		return l + r;
	}
		
}
public class Sub : IOperate
{
	private ILogger logger;
	public Sub(ILogger subLog)
	{
		this.logger = subLog;
	}
	
	public char Operand { get { return '-'; } }
	public int Func(int l, int r)
	
	{
		this.logger.LoggerMethod($"Calling Sub with {l} and {r}.");
		return l - r;
	}
}
public class Mod : IOperate
{
	private ILogger logger;
	public Mod(ILogger modLog)
	{
		this.logger = modLog;
	}
	public char Operand { get { return '%'; } }
	public int Func(int l, int r)
	{
		this.logger.LoggerMethod($"Calling Mod with {l} and {r}.");
		return l % r;
	}
}
public class Div : IOperate
{
	private ILogger logger;

	public Div(ILogger divLog)
	{
		this.logger = divLog;
	}

	public char Operand
	{ get { return '/'; } }
	
	public int Func(int left, int right)
	{
		this.logger.LoggerMethod($"Calling Div with {left} and {right}.");
		return left/right;
	}
}
public class Prod : IOperate
{
	private ILogger logger;
	
	public Prod(ILogger prodLog)
	{
		this.logger = prodLog;
	}
	public char Operand { get { return '*';} }
	public int Func(int left, int right)
	{
		this.logger.LoggerMethod($"Calling Prod with {left} and {right}.");
		return left * right;
	}
}
public interface IOperate
{
	char Operand { get; }
	int Func(int l, int r);
}
public interface ILogger
{
	void LoggerMethod(string message);
}
public class Logger : ILogger
{

	public void LoggerMethod(string message)
	{
		Console.Write(message);
	}
}
//public interface IFactory
//{
//	void Operand(char operand);
//}
//public class Factory : IFactory
//{
//	public void Operand(char operand)
//	{
//		private IFactory operts; 
//		public Factory(IFactory operators)
//		{
//			this.operts = operators;
//		}
//		IEnumerable<IOperate> operators
//		foreach (var o in operators)
//		{
//			if (o.Operand == op)
//			{
//				operatorInstance = o;
//				break;
//			}
//		}
//		if (operatorInstance is null)
//		{
//			"Cannot find operator instance for your operation.".Dump();
//			return;
//		}
//	}
//}