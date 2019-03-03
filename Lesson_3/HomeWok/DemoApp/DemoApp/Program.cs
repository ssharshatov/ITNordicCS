using System;
using System.Diagnostics;
using System.Globalization;

namespace DemoApp
{
internal class Program
	{
		private static void Main()
		{
		ConsoleOutPut outPut = new ConsoleOutPut();
		PeopleList pl = new PeopleList(outPut);
		pl.Run();
		pl.Write();
		}
	}
}