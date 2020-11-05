using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{

	class Program
	{
		public static bool Draw()
		{
			bool win = true, step = true;

			int rows = 3;
			int cols = 3;

			char[,] arr1 = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					arr1[i, j] = '#';
				}
			}

		link:
			System.Console.Clear();

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(arr1[i, j]);
					Console.Write("\t");
				}
				Console.WriteLine("\n");
			}
			if ((arr1[2, 0] == 'X' && arr1[2, 1] == 'X' && arr1[2, 2] == 'X') || (arr1[1, 0] == 'X' && arr1[1, 1] == 'X' && arr1[1, 2] == 'X') || (arr1[0, 0] == 'X' && arr1[0, 1] == 'X' && arr1[0, 2] == 'X')
				|| (arr1[0, 0] == 'X' && arr1[1, 0] == 'X' && arr1[2, 0] == 'X') || (arr1[0, 1] == 'X' && arr1[1, 1] == 'X' && arr1[2, 1] == 'X') || (arr1[0, 2] == 'X' && arr1[1, 2] == 'X' && arr1[2, 2] == 'X')
				|| (arr1[0, 0] == 'X' && arr1[1, 1] == 'X' && arr1[2, 2] == 'X') || (arr1[2, 0] == 'X' && arr1[1, 1] == 'X' && arr1[0, 2] == 'X'))
			{
				Console.WriteLine("X win!");
				win = false;
				return win;
			}
			else if ((arr1[2, 0] == 'O' && arr1[2, 1] == 'O' && arr1[2, 2] == 'O') || (arr1[1, 0] == 'O' && arr1[1, 1] == 'O' && arr1[1, 2] == 'O') || (arr1[0, 0] == 'O' && arr1[0, 1] == 'O' && arr1[0, 2] == 'O')
				|| (arr1[0, 0] == 'O' && arr1[1, 0] == 'O' && arr1[2, 0] == 'O') || (arr1[0, 1] == 'O' && arr1[1, 1] == 'O' && arr1[2, 1] == 'O') || (arr1[0, 2] == 'O' && arr1[1, 2] == 'O' && arr1[2, 2] == 'O')
				|| (arr1[0, 0] == 'O' && arr1[1, 1] == 'O' && arr1[2, 2] == 'O') || (arr1[2, 0] == 'O' && arr1[1, 1] == 'O' && arr1[0, 2] == 'O'))
			{
				Console.WriteLine("O win!");
				win = false;
				return win;
			}
			else if ((arr1[2, 0] != '#' && arr1[2, 1] != '#' && arr1[2, 2] != '#') && (arr1[1, 0] != '#' && arr1[1, 1] != '#' && arr1[1, 2] != '#') && (arr1[0, 0] != '#' && arr1[0, 1] != '#' && arr1[0, 2] != '#')
				&& (arr1[0, 0] != '#' && arr1[1, 0] != '#' && arr1[2, 0] != '#') && (arr1[0, 1] != '#' && arr1[1, 1] != '#' && arr1[2, 1] != '#') && (arr1[0, 2] != '#' && arr1[1, 2] != '#' && arr1[2, 2] != '#')
				&& (arr1[0, 0] != '#' && arr1[1, 1] != '#' && arr1[2, 2] != '#') && (arr1[2, 0] != '#' && arr1[1, 1] != '#' && arr1[0, 2] != '#'))
			{
				Console.WriteLine("Ничья!");
				win = false;
				return win;
			}




			while (step)
			{
				Console.WriteLine("Укажите позицию для X");

				ConsoleKey position;
				position = Console.ReadKey().Key;

				switch (position)
				{
					case ConsoleKey.NumPad1:
						if (arr1[2, 0] == '#')
						{
							arr1[2, 0] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}
						goto link;

					case ConsoleKey.NumPad2:
						if (arr1[2, 1] == '#')
						{
							arr1[2, 1] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}
						goto link;

					case ConsoleKey.NumPad3:
						if (arr1[2, 2] == '#')
						{
							arr1[2, 2] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad4:
						if (arr1[1, 0] == '#')
						{
							arr1[1, 0] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad5:
						if (arr1[1, 1] == '#')
						{
							arr1[1, 1] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad6:
						if (arr1[1, 2] == '#')
						{
							arr1[1, 2] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad7:
						if (arr1[0, 0] == '#')
						{
							arr1[0, 0] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad8:
						if (arr1[0, 1] == '#')
						{
							arr1[0, 1] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad9:
						if (arr1[0, 2] == '#')
						{
							arr1[0, 2] = 'X';
							step = false;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					default:
						break;
				}
			}

			while (!step)
			{
				Console.WriteLine("Укажите позицию для O");

				ConsoleKey position;
				position = Console.ReadKey().Key;

				switch (position)
				{
					case ConsoleKey.NumPad1:
						if (arr1[2, 0] == '#')
						{
							arr1[2, 0] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}
						goto link;

					case ConsoleKey.NumPad2:
						if (arr1[2, 1] == '#')
						{
							arr1[2, 1] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}
						goto link;

					case ConsoleKey.NumPad3:
						if (arr1[2, 2] == '#')
						{
							arr1[2, 2] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad4:
						if (arr1[1, 0] == '#')
						{
							arr1[1, 0] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad5:
						if (arr1[1, 1] == '#')
						{
							arr1[1, 1] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad6:
						if (arr1[1, 2] == '#')
						{
							arr1[1, 2] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad7:
						if (arr1[0, 0] == '#')
						{
							arr1[0, 0] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad8:
						if (arr1[0, 1] == '#')
						{
							arr1[0, 1] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					case ConsoleKey.NumPad9:
						if (arr1[0, 2] == '#')
						{
							arr1[0, 2] = 'O';
							step = true;
						}
						else
						{
							Console.WriteLine("Клетка уже не пуста!");
							System.Threading.Thread.Sleep(500);
						}

						goto link;

					default:
						break;
				}

			}

			return win;
		}


		static void Main(string[] args)
		{
		link2:
			bool game = true;


			do
			{
				game = Draw();

			} while (game);

			Console.WriteLine("GameOver");
			Console.WriteLine("Чтобы начать завново, нажмите - R");
			Console.WriteLine("Чтобы закрыть консоль, нажмите - E");

			ConsoleKey begin;
			begin = Console.ReadKey().Key;

			switch (begin)
			{
				case ConsoleKey.R:
					goto link2;
				case ConsoleKey.E:
					Environment.Exit(0);
					break;
				default:

					break;
			}

			Console.ReadKey();
		}
	}
}
