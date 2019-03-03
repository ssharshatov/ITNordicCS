using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
	public class PeopleList
	{
		private string[][,,] peopleData = new string[4][,,];
		
		private PeopleList0 pl;

		public PeopleList(ConsoleOutPut consoleWriter)
		{
			pl = new PeopleList0(consoleWriter);
		}

		public void Run()
		{
			pl.WriteTitle();

			for (int i = 0; i < peopleData.Length; i++)
			{
				string name = pl.ReadPeopleName("Введите имя человека №" + i);
				peopleData[i][0,0,0] = name;
			}

			for (int i=0;i<peopleData.Length;i++)
			{
				int age = pl.ReadPeopleAge("Введите возврат" + peopleData[i]);
				peopleData[i][0,0,0] = Convert.ToString(age);
				peopleData[i][0,0,1] = Convert.ToString(age+4);
			}
		}

		public void Write()
		{
			pl.WritePeopleList(peopleData);
		}

	}


}
