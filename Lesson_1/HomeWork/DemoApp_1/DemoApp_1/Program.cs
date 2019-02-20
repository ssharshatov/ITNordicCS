using System;
using System.Threading;

namespace DemoApp_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите имя и нажмите Enter");
			String name = Console.ReadLine();
			Thread.Sleep(5000);
			Console.WriteLine($"Здравствуйте, {name}!");
			Thread.Sleep(2000);
			Console.WriteLine($"Спасибо за внимание. Ждем новых встреч, {name}!");
			Console.ReadKey();
		}
	}
}
