using System;
namespace LanguagePractice
{
	public class TypeConversion
	{
		public static void typeConversion()
		{
			// 1. Implicit Type Conversion :- that can be done automatically, for example:- change the integer to double.
			int i1 = 34;
			Console.WriteLine(i1);
			double d1 = i1;
			Console.WriteLine(d1);

			// 2. Explicit Type Conversion :- where data type cannot be changed automatically . and the manual change is required.
			// for example:-

			double dd1 = 34.45;
            Console.WriteLine(dd1);
            int ii1 = (int)dd1;
            Console.WriteLine(ii1);

			// 3. Parsing :- To convert only string values to required type. It throw exception if conversion cannot be done.
			// USED WHEN WE WANT TO HANDLE THE RUN TIME EXCEPTION INSTEAD OF FACING COMPILE TIME ERRORS.
			// ONLY USED TO CONVERT STRING.

			string age = "34";
            Console.WriteLine(age + 34);
            int Age = int.Parse(age);
			Console.WriteLine(Age + 34);
        }
	}
}

