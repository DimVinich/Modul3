using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			
			Console.Write("Enter your age: ");
			byte age = checked((byte)int.Parse(Console.ReadLine()));
			
			Console.WriteLine("Your name is {0} and age is {1} ", name, age);

			Console.Write("Enter your birthdate: ");
			var birthdate = Console.ReadLine();
			Console.WriteLine("Your birthdate is {0} ", birthdate);

			Console.ReadKey();
		}
	}
}

/*
			DayOfWeek FavorDay;
			Console.Write("И Ваш любимый день: ");
			FavorDay = (DayOfWeek) int.Parse(Console.ReadLine());
			Console.Write("Ваш любимый день {0}", FavorDay);

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
		enum Semaphore
		{
			Red = 100,
			Yellow = 200,
			Green = 300
		}

*/
//Console.WriteLine("\u0040");
//Console.WriteLine("\u0023");
//			Console.ReadKey();

