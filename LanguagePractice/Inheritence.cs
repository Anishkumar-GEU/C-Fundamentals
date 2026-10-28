using System;
namespace LanguagePractice
{
	public class Inheritence
	{
		public static void method_1()
		{
			Console.WriteLine("I am the parent class ...");
		}
	}
	public class Inherited : Inheritence
	{
		public static void method_2()
		{
			Console.WriteLine("I am the child class ...");
			Console.WriteLine("I can be the parent");
		}
	}
}

// INHERITENCE CAN BE OF 3 TYPES
// 1. SINGLE INHERITENCE :- one class is derived from other.
// 2. MULTILEVEL INHERITENCE :- one class can be derived from another derived class.
// 3. HEIRARCHICAL INHERITENCE :- many class can be derived from one class.

// WE WILL LEARN INHERITENCE IN MORE DETAIL WITH ANIMAL CLASS.