using System;
namespace LanguagePractice
{
	public class ConstReadOnly
	{
		// 1. CONST
		/*
		 * const ki value compile time pe assign aur fix hoti hai .
		 * yaani ki jab cons variable create karte hain to const ki value assign karni padti hai.
		 * const ki value humesha fix rehti hai.
		 */

		const double pii = 3.24;

		// 2. READONLY
		/*
		 * readonly ki value run time pe assign aur fix hoti hai.
		 * readonly variable ko tab value milti hai jab unka instance create hota hai.
		 * isliye unko constructors ke andar value assign ki jati hai.
		 * readonly ki value humesha ke liye fix hojati hai ek baar assign hone ke baad jab uska object banta hai.
		 * har object ke liye readonly ki value alag ho sakti hai.
		 */
		readonly int z;
		public ConstReadOnly()
		{
			z = 34;
		}
	}
}

