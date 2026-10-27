using System;
namespace LanguagePractice
{
	public class ConstructorChaining
	{
        /*

    public class ConstrChain
    {
		public ConstrChain() : this(12)
        {
            Console.WriteLine("def const");
        }

        public ConstrChain(int x) : this("test")
        {
            Console.WriteLine("1 int");
        }

        public ConstrChain(string x)
        {
            Console.WriteLine("1 string");
        }

        public ConstrChain(int x, int y)
        {
            Console.WriteLine("2 int");
        }
    }

    public class Child : ConstrChain
    {

        public Child() : base()
        {
            Console.WriteLine(" child constr");
        }
    }
		 
		 */
    }
}

// Child() constructor mein base() ka matlab hai ki woh parent class ke parameterless constructor, yani ConstrChain(), ko call karega.
// aur this() ka matlab hai ki vo agle constructor ko call karega jisse this() ke parameters match honge.