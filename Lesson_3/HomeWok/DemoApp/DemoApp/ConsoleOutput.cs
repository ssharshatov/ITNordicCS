using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace DemoApp
{
	public class ConsoleOutPut
	{
		public ConsoleOutPut()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		}

		public void Write(string text)
		{
			Console.Write(text);
			Console.Write("\n");
		}

		public void WriteWithRed(string text)
		{
			WriteWithColor(text, ConsoleColor.Red);
		}

		public void WriteWithGreen(string text)
		{
			WriteWithColor(text, ConsoleColor.Green);
		}

		public void WriteWithYellow(string text)
		{
			WriteWithColor(text, ConsoleColor.Yellow);
		}

		private void WriteWithColor(string text, ConsoleColor color)
		{
			ConsoleColor restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(text);
			Console.Write("\n");
			Console.ForegroundColor = restoreColor;
		}
	}
}
