using System;
namespace LanguagePractice
{
	public class SwitchCase
	{
		public static void switch_case()
		{
			int age = 4;
			switch (age)
			{
				case 3:
					Console.WriteLine("Three");
					break;
				case 4:
					Console.WriteLine("Hello");
					break;
				default:
					Console.WriteLine("Invalid");
					break;
			}
		}

	}
}

