using System;
namespace LanguagePractice
{
	public class ConstructorOverloading
	{
		public ConstructorOverloading()
		{
			Console.WriteLine("Hello");
		}
		public ConstructorOverloading(string name)
		{
			Console.WriteLine("Hello "+name);
		}
	}
}

// Constructor Overloading: Ek hi class mein multiple constructors banana, jinki parameter lists different hon.
