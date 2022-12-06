using System;

namespace map_moving_1
{
    class Program
    {
        static void PrintArray2d(char[,] a2d)
        {
            for (int i = 0; i < a2d.GetLength(0); i++)
            {
                for (int j = 0; j < a2d.GetLength(1); j++)
                {
                    Console.Write(a2d[i, j]);
                }
                Console.WriteLine();
            }
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

            char[,] map = new char[10, 17];


            // 把s的内容依次拷贝到数组map中去
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = s[i * 18 + j];
                }
            }

            // 玩家位置
            int row = 5;
            int column = 5;

            map[row, column] = 'O';

            char lastChar = ' ';

            while(true)
            {
                Console.Clear();
                PrintArray2d(map);

                ConsoleKeyInfo info = Console.ReadKey();

                if(info.Key == ConsoleKey.UpArrow)
                {
                    if(map[row - 1,column] != '#')
                    {
                        map[row, column] = lastChar;
                        lastChar = map[row - 1, column];
                        map[row - 1, column] = 'O';
                        row -= 1;
                    }
                }
                if(info.Key == ConsoleKey.DownArrow)
                {
                    if(map[row + 1,column] != '#')
                    {
                        map[row, column] = lastChar;
                        lastChar = map[row + 1, column];
                        map[row + 1, column] = 'O';
                        row += 1;
                    }
                   
                }
                if(info.Key == ConsoleKey.LeftArrow)
                {
                    if(map[row,column - 1] != '#')
                    {
                        map[row, column] = lastChar;
                        lastChar = map[row, column - 1];
                        map[row, column - 1] = 'O';
                        column -= 1;
                    }
                }
                if(info.Key == ConsoleKey.RightArrow)
                {
                    if(map[row,column + 1] != '#')
                    {
                        map[row, column] = lastChar;
                        lastChar = map[row,column + 1];
                        map[row, column + 1] = 'O';
                        column += 1;
                    }
                }
            }
            Console.ReadKey();
        }

       
    }
}
