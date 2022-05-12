using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
			string MyName = "Dmitrij";
			string name = "Dmitrij";
			byte age = 50;
			string favcolor = "Зелёный";
			byte weight = 80;

			Console.WriteLine("\t Привет,\n мир!");
			Console.WriteLine();
			Console.WriteLine($"Меня зовут {MyName}");
			Console.WriteLine($"Мой возраст {age}");

			Console.WriteLine("{0} \n\t {1} \n {2}", name, age,  favcolor);

			string str =Console.ReadLine();
		}


		enum Semaphore
		{
			Red = 100,
			Yellow = 200,
			Green = 300
		}

	}
}

/*
			byte MyAge = 50;
			bool HavePet = false;
			double MyShoeSize = 42;

			Console.WriteLine("My name is {0}", MyName);
			Console.WriteLine("My Age is {0}", MyAge);
			Console.WriteLine("Do I have a pate? "+HavePet);
			Console.WriteLine("My shoe size is " + MyShoeSize);

*/
//Console.WriteLine("\u0040");
//Console.WriteLine("\u0023");
//			Console.ReadKey();

