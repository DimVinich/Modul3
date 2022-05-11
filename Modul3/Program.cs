using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
			string MyName = "Dmitrij";
			byte MyAge = 50;
			bool HavePet = false;
			double MyShoeSize = 42;

			Console.WriteLine("My name is {0}", MyName);
			Console.WriteLine("My Age is {0}", MyAge);
			Console.WriteLine("Do I have a pate? "+HavePet);
			Console.WriteLine("My shoe size is " + MyShoeSize);


			//Console.WriteLine("\u0040");
			//Console.WriteLine("\u0023");
			//			Console.ReadKey();
		}
	}
}
