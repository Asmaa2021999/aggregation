using System;

public class testClass
{
	public static void Main(String[] args)
	{
		Address a1 = new Address("Al Ain", "Abu Dhabi", "UAE");
		Employee e1 = new Employee("Asmaa ", "EMP001", a1);
		Console.WriteLine(e1.toString());
	}
}
