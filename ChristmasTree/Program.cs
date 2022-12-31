namespace ChristmasTree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int length = 10;

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length - i; j++)
				{
					Console.Write(" ");
				}
				for (int j = 0; j < i * 2 + 1; j++)
				{
					Console.ForegroundColor = random.Next(0, 10) > 5 ? ConsoleColor.DarkGreen : ColorProvider.GetRandomColor();

					Console.Write("#");
				}
				Console.WriteLine();
			}
			for (int i = 0; i < length - 1; i++)
			{
				Console.Write(" ");
			}
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			for (int i = 0; i < length/10+2; i++)
			{
				Console.Write("|");
			}
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}