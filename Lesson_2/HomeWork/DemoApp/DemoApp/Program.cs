using System;

namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в приложение 'Калькулятор'");

			char[] typesList = new char[3] { 'd', 'i', 'f' };
			char typeFirstNumber='t';

			Console.WriteLine("Введите тип данных для первого числа (d-double;i-integer;f-float):");

			while (char.TryParse(Console.ReadLine(), out typeFirstNumber)) {
				Console.WriteLine("Введите тип данных для первого числа (d-double;i-integer;f-float):");

				while (!Array.Exists(typesList, element => element == typeFirstNumber))
				{
					Console.WriteLine("Вы ввели не корректный тип данных: ");
					break;
				}
			}

			if (typeFirstNumber == 'd') {
				Console.WriteLine("Введите первое число:");
				double firstNumber;
				while (!double.TryParse(Console.ReadLine(), out firstNumber))
					Console.WriteLine("Введит тип данных Double, повторите ввод");
			}
				else if (typeFirstNumber == 'i')
			{ }

		}
	}
}
