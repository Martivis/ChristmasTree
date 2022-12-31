using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
	internal static class ColorProvider
	{
		static Random random = new Random();
		static ColorProvider()
		{
			random = new Random();
		}

		static public ConsoleColor GetRandomColor()
		{
			return (ConsoleColor)random.Next(0, Enum.GetNames(typeof(ConsoleColor)).Length);
		}
	}
}
