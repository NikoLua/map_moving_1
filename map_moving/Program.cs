using System;

namespace map_moving
{
    class Program
    {
        static void PrintArray2d(char[,] buffer)
        {
            for (int i = 0; i < buffer.GetLength(0); i++)
            {
                for (int j = 0; j < buffer.GetLength(1); j++)
                {
                    Console.Write(buffer[i, j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] map = new char[10, 17];

        static char[,] buffer = new char[10, 17];

        // 玩家位置
        static int row = 5;
        static int column = 5;

        static void DrawBuffer()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    buffer[i, j] = map[i, j];   
                }
            }

            buffer[row, column] = 'O';
        }

        static void Main(string[] args)
        {
            string s = ""
               + "#################\n"
               + "#               #\n"
               + "#    ~~~     H  #\n"
               + "#      ~~~      #\n"
               + "#        ~~~    #\n"
               + "#    C    ~~~   #\n"
               + "#     D  C  ~~~ #\n"
               + "#               #\n"
               + "#               #\n"
               + "#################\n";

            Console.Write(s);


            // 把s的内容依次拷贝到数组map中去
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = s[i * 18 + j];
                }
            }

            while (true)
            {
                DrawBuffer();
                Console.Clear();
                PrintArray2d(buffer);

                ConsoleKeyInfo info = Console.ReadKey();


                if (info.Key == ConsoleKey.UpArrow)
                {
                    if (map[row - 1, column] != '#')
                    {
                        row -= 1;
                    }
                }
                if (info.Key == ConsoleKey.DownArrow)
                {
                    if (map[row + 1, column] != '#')
                    {
                        row += 1;
                    }
                }
                if (info.Key == ConsoleKey.LeftArrow)
                {
                    if (map[row, column - 1] != '#')
                    {
                        column -= 1;
                    }
                }
                if (info.Key == ConsoleKey.RightArrow)
                {
                    if (map[row, column + 1] != '#')
                    {
                        column += 1;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
