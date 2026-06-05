using System;

public abstract class Person
{
	public abstract string GetName();
	
}
public class Student : Person
{
	public override string GetName()
	{
		return "Student";
	}
}

public class Teacher : Person
{
	public override string GetName()
	{
		return "Teacher";
	}
}
