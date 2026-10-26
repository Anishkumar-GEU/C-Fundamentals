using System;
namespace LanguagePractice
{
	public class DataTypes
	{
		public static void dataTypes()
		{
			// integral values signed and unsigned types.

			// byte
			byte b1 = 23; // only +ve accepted
			sbyte b2 = -23; // -ve and +ve both values are allowed

			// short
			short s1 = -2; // +ve and -ve value accepted
			ushort s2 = 2; // only +ve accepted

			// int
			int i1 = -23; // +ve and -ve both values are allowed
			uint i2 = 25; // only +ve values are allowed

			// long
			long l1 = -23334;// +ve and -ve both values are allowed.
			ulong l2 = 354645; // only +ve values are allowed


			// float
			float f1 = -34.454f; // both +ve and -ve values are allowed

			// double
			double d1 = -353455.435456365; // both +ve and -ve values are allowed

			// decimal
			decimal dm1 = -34.324m; // both +ve and -ve values are allowed


			// QUES :- WHAT IS THE DIFFERENCE BETWEEN DECIMAL AND DOUBLE DATATYPE IN C# ?
			// ANS :- DECIMAL(16 BYTES) AND DOUBLE(8 BYTES).
			//			IN DECIMAL MANY DECIMAL FRACTIONS ARE EXACT WHEREAS IN DOUBLE MANY ARE APPROXIMATE.


			// bool
			bool bol1 = false;

			// string
			string name = "Anish Kumar";

			// char
			char c1 = 'A';

			// var
			var surname = "kumar";
			//surname = 4; // this will give a compile time error because var data type has been assigned at compile time.

			// dynamic
			dynamic full_name = "Anish Kumar";
			full_name = 55; // dynamic variable has been assigned at run time . so it will not give an error.

			// object
			object o1 = 34.45;
			o1 = "Anmol";  // object is reference type.
			

		}
	}
}

