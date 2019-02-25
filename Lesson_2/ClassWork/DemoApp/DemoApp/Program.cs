using System;

namespace DemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			char letter = 'a';
			Console.WriteLine(letter);

			string name = "Test";
			name = name.ToUpper();
			Console.WriteLine(name);

			float x1 = 3.5F;
			Console.WriteLine(x1);

			int x = 3;
			float y = 4.5f;
			short z = 5;
			var result = x * y / z;
			Console.WriteLine("The result is {0}", result);
			Type type = result.GetType();
			Console.WriteLine("result is of type {0}", type.ToString());

			float xx = float.NaN;
			float zero = 0;
			Console.WriteLine("{0} / {0} = {1}",zero,zero/zero);
			Console.WriteLine(zero / zero == xx);

 * 			 */

			Console.WriteLine("Введите радиус круга");

			double radius = double.Parse(Console.ReadLine());

			double area = Math.PI * (Math.Pow(radius, 2));

			Console.WriteLine( "Площадь круга:" + area);
		
			Console.ReadKey();
		}
	}
}
