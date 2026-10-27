using System;
namespace LanguagePractice
{
	public class Method_Overloading
	{
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
        /*
         * Parameters ki number different ho sakti hai.
         * Parameters ke data types different ho sakte hain.
         * Parameters ka order different ho sakta hai.
         * Sirf return type change karne se overloading nahi hoti.
         */

    }
}

