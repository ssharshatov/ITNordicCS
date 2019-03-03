using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
	public class PeopleList0
	{
		private readonly ConsoleOutPut _writer;

		public PeopleList0(ConsoleOutPut consoleWriter)
		{
			_writer = consoleWriter;
		}

		public void WriteTitle()
		{
			_writer.WriteWithYellow("Добро пожаловать в справочник физических лиц");
		}

		public void WritePeopleList(string [][,,] pl)
		{
			for (int i =0 ; i < pl.Length; i++)
			{
				_writer.Write("Физическое лицо: " + pl[i]);
				_writer.WriteWithGreen("Текущий возврат: " + pl[i][0,0, 0]);
				_writer.WriteWithGreen("Возврат через 4 года:" + pl[i][0,0, 1]);
				_writer.WriteWithYellow("-------------------------------------------------");

			}
		}
		public int ReadPeopleAge(string AgeDescription)
		{
			int age;

			while (true)
			{
				_writer.Write(AgeDescription);
				if (int.TryParse(Console.ReadLine(), out age))
					break;
				_writer.WriteWithRed("Вы ввели не корректный возраст");
			}
			return age;
		}
		public string ReadPeopleName(string NameDescription)
		{
			string name;

			while (true)
			{
				_writer.Write(NameDescription);
				name = Console.ReadLine();
				if (name.Length > 3)
					break;

				_writer.WriteWithRed("Вы ввели не корректные данные, повторите попытку");
			}

			return name;
		}
	}

}
