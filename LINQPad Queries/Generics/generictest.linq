<Query Kind="Program" />

void Main()
{
	GenericList<int> gList1 = new GenericList<int>();
	
	gList1.Add(12);
	gList1.Add(12);
	gList1.Add(12);
	gList1.Add(12);
	gList1.Add(12);
	gList1.Add(12);
	gList1.Add(12);
	
	gList1.AddUnique(13);
	
 	gList1.Dump();
	
	GenericList<string> gListString	 = new GenericList<string>();
	
	gListString.Add("word");
	gListString.AddUnique("word");
	
	gListString.Dump();
	
	int first = 5;
	int second = 8;
	
	Common.SwapB(first, second);
	
	Console.WriteLine(first + " " + second);
	
	Pairs p1 = new Pairs{num1 = 2, num2 = 4};
	Pairs p2 = new Pairs{num1 = 5, num2 = 8};
	
	Common.Swap(ref p1, ref p2);
	
	p1.Dump();
	p2.Dump();

	Common.SwapB(p1, p2);
	p1.Dump();
	p2.Dump();
}




//Part 2 - Generic Class
//Create a generic class called GenericList.It needs to implement the following methods:


class GenericList<T>
{

	//You don't need to create anything special for holding the data, you can just use a system.Collections.Generic.List to hold the data. (It is a great example of a generic class itself).
	List<T> Generic = new List<T>();
	//and have an Int Count property with just get.

	//the property should just Get the count of items in the List object which has a property of the same name.
	int Count
	{
		get
		{
			return Generic.Count;
		}
	}
	
	public override string ToString()
	{
		return string.Join("," , this.Generic);
	}
	
	//bool Add(T entry)
	public bool Add(T entry)
	{
		//The add method always adds the value given.Returns true if it was added, false if there were any problems. (List.Add is your friend)
		Generic.Add(entry);
		return true;
	}
	//bool AddUnique(T entry)
	public bool AddUnique(T entry)
	{
		//The AddUnique method will check if the value is in the list(You can use the List.Contains() method to check if it already exists). If it is in the list already, return false.Otherwise add the value to the list and return true.
	if(!Generic.Contains(entry))
	{
		Generic.Add(entry);
		return true;
	}
	else
	{
		return false;
	}

	}
	//bool Remove(T entry)
	public bool Remove(T entry)
	{
		return Generic.Remove(entry);
		
		//Remove will take out the entry from the list (List.Remove will help here)
		
	}
	//T Get(int index)
	T Get(int index)
	{
		//Get will return the value at the index given.
	return Generic[index];
		
	}
}

//Part 1 - Generic Methods
//Create a Static class called Common.
public static class Common
{
	//In the class create a method with the following signature:
	//Swap<T>(ref T a, ref T b)
	//(FYI, the ref is important for swapping because we can't return two values and the basic data types won't work withouth the ref type) Let me know if you have any questions on this.
	//This method should put the value of a into b and b into a.You can then see that the variables now have the other value in it.
	public static void Swap<T>(ref T a, ref T b)
	{
		T swap = a;
		a = b;
		b = swap;
	}
	
	public static void SwapB<T>(T a, T b)
	{
		T swap = a;
		a = b;
		b = swap;
	}
}

public class Pairs
{
	
	public int num1{get; set;}
	public int num2{get; set;}

	public override string ToString()
	{
		return $"num1 = {num1} num2 = {num2}";
	}
}

//Of course in general you should just use the List object, but this is for learning about generics.