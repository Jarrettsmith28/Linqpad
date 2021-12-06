<Query Kind="Expression" />

void Main()
{
	Cat cat = new Cat();
	cat.Noise();
	IAnimal dog = new Dog();
	dog.Noise();
}
public interface IAnimal
{
	void Noise();
	int NumberOfLives();
}
public class Cat : IAnimal
{
	public void Foo()
	{
	}
	public void Noise()
	{
		"Meow".Dump();
	}
	public int NumberOfLives()
	{
		return 9;
	}
}
public class Dog : IAnimal
{
	public void Noise()
	{
		"Bark".Dump();
	}
	public int NumberOfLives()
	{
		return 1;
	}
}