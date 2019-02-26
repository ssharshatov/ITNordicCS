using System;

namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в приложение 'Калькулятор'");

			char[] typesList = new char[3] { 'd', 'i', 'f' };
			char typeFirstNumber;

			Console.WriteLine("Введите тип данных для первого числа (d-double;i-integer;f-float):");

			while (!char.TryParse(Console.ReadLine(), out typeFirstNumber))
			{
				Console.WriteLine("Введите тип данных для первого числа (d-double;i-integer;f-float):");
				do
				{
					Console.WriteLine("Вы ввели не корректный тип данных, повторите попытку: ");
					break;
				} while (!Array.Exists(typesList, element => element == typeFirstNumber));
			}

			if (typeFirstNumber == 'd')
			{
				Console.WriteLine("Введите первое число:");
				var firstNumber = 34.34;
				while (!double.TryParse(Console.ReadLine(), out firstNumber))
					Console.WriteLine("Введите тип данных Double, повторите ввод");
			}
			else if (typeFirstNumber == 'i')
			{
				Console.WriteLine("Введите первое число:");
				int firstNumber = 34;
				while (!int.TryParse(Console.ReadLine(), out firstNumber))
					Console.WriteLine("Введите тип данных Integer, повторите ввод");
			}
			else if (typeFirstNumber == 'f')
			{
				Console.WriteLine("Введите первое число:");
				float firstNumber = 34.34f;
				while (!float.TryParse(Console.ReadLine(), out firstNumber))
					Console.WriteLine("Введите тип данных Float, повторите ввод");
			}
		}
	}
}
