using System;

namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*dynamic number = 10;
			string number1 = "12.3425";

			Console.WriteLine(number.ToString());

			double resualt2 = number + double.Parse(number1,System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

			Console.WriteLine(resualt2);
			Console.ReadKey();*/

			/* var f = 3.14f;
			var d = 1D;
			var l = 49L;
			var b = (byte)255;

			Console.WriteLine(f.GetType());
			Console.WriteLine(d.GetType());
			Console.WriteLine(l.GetType());
			Console.WriteLine(b.GetType());

			Console.WriteLine(default(string) is null);
			Console.WriteLine(default(int));

			double? k = null;
			do
			{
				try
				{
					k = Convert.ToDouble(Console.ReadLine());
				}
				catch { }
			} while (!k.HasValue);

			Console.WriteLine(k.Value);


			Console.ReadKey();
			*/

			var array = new string[5];
			
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Console.ReadLine();
				}
			

			for (int i = array.Length - 1; i>=0; i--)
			{
				Console.Write(array[i] + "\n");
			}

			Console.ReadKey();

		}
	}
}
