using System;
using System.Threading;

namespace DemoApp_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите имя");
			String name = Console.ReadLine();
			Thread.Sleep(5000);
			Console.WriteLine($"Здравствуйте, {name}!");
			Console.ReadKey();
		}
	}
}
