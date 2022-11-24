using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOPR_Systems
{
    public static class Games
    {
        public static class FalkensMaze
        {
            private static Maze TheMaze;
            private static Player ThePlayer;
            private static string[,] map =
            {
                { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█"},
                { "█", " ", "█", " ", " ", " ", "█", " ", " ", " ", "█", " ", "█", " ", "█", " ", "█", " ", "█", "█", "█", " ", " ", " ", "█", "█", "█"},
                { "█", " ", "█", " ", "█", " ", "█", " ", "█", " ", " ", " ", "█", " ", "█", " ", " ", " ", "█", "█", "█", " ", "█", " ", "█", "█", "█"},
                { "█", " ", "█", " ", "█", " ", "█", " ", "█", " ", "█", " ", " ", " ", "█", " ", "█", " ", " ", " ", " ", " ", "█", " ", " ", "X", "█"},
                { "█", " ", " ", " ", "█", " ", " ", " ", "█", " ", "█", " ", "█", " ", " ", " ", "█", " ", "█", "█", "█", "█", "█", "█", "█", "█", "█"},
                { "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█", "█"},
                { "A", "r", "r", "o", "w", " ", "k", "e", "y", "s", " ", "t", "o", " ", "m", "o", "v", "e", ".", "", "", "", "", "", "", "", ""}
            };



            public static void StartGame()
            {
                Console.Clear();
                Program.TypeOut("Setting up Falken's Maze.....\nPress any key to continue.....", 25, true, false);
                Console.ReadKey();
                Console.Clear();

                TheMaze = new Maze(map);
                TheMaze.Draw();

                ThePlayer = new Player(1, 1);
                ThePlayer.Draw();

                Run();
            }

            private static void DrawFrame()
            {
                Console.Clear();
                TheMaze.Draw();
                ThePlayer.Draw();
            }

            private static void HandleInput()
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (TheMaze.IsPosWalkable(ThePlayer.X, ThePlayer.Y - 1))
                        {
                            ThePlayer.Y -= 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (TheMaze.IsPosWalkable(ThePlayer.X, ThePlayer.Y + 1))
                        {
                            ThePlayer.Y += 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (TheMaze.IsPosWalkable(ThePlayer.X - 1, ThePlayer.Y))
                        {
                            ThePlayer.X -= 1;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (TheMaze.IsPosWalkable(ThePlayer.X + 1, ThePlayer.Y))
                        {
                            ThePlayer.X += 1;
                        }
                        break;
                }
            }

            private static void Run()
            {
                Console.CursorVisible = false;
                while (true)
                {
                    DrawFrame();

                    HandleInput();

                    string elementAtPlayer = TheMaze.GetElementAt(ThePlayer.X, ThePlayer.Y);
                    if (elementAtPlayer == "X")
                    {
                        Console.Clear();
                        /*        ___  __   __ _   ___  ____   __  ____  _  _  __     __  ____  __  __   __ _  ____  _   
                                 / __)/  \ (  ( \ / __)(  _ \ / _\(_  _)/ )( \(  )   / _\(_  _)(  )/  \ (  ( \/ ___)/ \  
                                ( (__(  O )/    /( (_ \ )   //    \ )(  ) \/ (/ (_/\/    \ )(   )((  O )/    /\___ \\_/  
                                 \___)\__/ \_)__) \___/(__\_)\_/\_/(__) \____/\____/\_/\_/(__) (__)\__/ \_)__)(____/(_)  
                                                 _  _  __   _  _  _ _  _  ____    _  _   __   __ _  _                    
                                                ( \/ )/  \ / )( \(// )( \(  __)  / )( \ /  \ (  ( \/ \                   
                                                 )  /(  O )) \/ (  \ \/ / ) _)   \ /\ /(  O )/    /\_/                   
                                                (__/  \__/ \____/   \__/ (____)  (_/\_) \__/ \_)__)(_)                   
                         */
                        Console.WriteLine("  ___  __   __ _   ___  ____   __  ____  _  _  __     __  ____  __  __   __ _  ____  _   \r\n / __)/  \\ (  ( \\ / __)(  _ \\ / _\\(_  _)/ )( \\(  )   / _\\(_  _)(  )/  \\ (  ( \\/ ___)/ \\  \r\n( (__(  O )/    /( (_ \\ )   //    \\ )(  ) \\/ (/ (_/\\/    \\ )(   )((  O )/    /\\___ \\\\_/  \r\n \\___)\\__/ \\_)__) \\___/(__\\_)\\_/\\_/(__) \\____/\\____/\\_/\\_/(__) (__)\\__/ \\_)__)(____/(_)  \r\n _  _  __   _  _  _ _  _  ____    _  _   __   __ _  _                                    \r\n( \\/ )/  \\ / )( \\(// )( \\(  __)  / )( \\ /  \\ (  ( \\/ \\                                   \r\n )  /(  O )) \\/ (  \\ \\/ / ) _)   \\ /\\ /(  O )/    /\\_/                                   \r\n(__/  \\__/ \\____/   \\__/ (____)  (_/\\_) \\__/ \\_)__)(_)                                   ");
                        
                        break;
                    }

                    Thread.Sleep(20);
                }
                Console.CursorVisible = true;
            }



            public class Maze
            {
                private string[,] Map;
                private int Rows;
                private int Cols;

                public Maze(string[,] map)
                {
                    Map = map;
                    Rows = map.GetLength(0);
                    Cols = map.GetLength(1);
                }

                public void Draw()
                {
                    for (int y = 0; y < Rows; y++)
                    {
                        for (int x = 0; x < Cols; x++)
                        {
                            string element = Map[y, x];
                            Console.SetCursorPosition(x, y);
                            Console.Write(element);
                        }
                    }
                }

                public string GetElementAt(int x, int y)
                {
                    return Map[y, x];
                }

                public bool IsPosWalkable(int x, int y)
                {
                    if (x < 0 || y < 0 || x >= Cols || y >= Rows)
                    {
                        return false;
                    }

                    return Map[y, x] == " " || Map[y, x] == "X";
                }
            }

            public class Player
            {
                public int X { get; set; }
                public int Y { get; set; }
                private string Icon;
                private ConsoleColor Color;

                public Player(int startX, int startY)
                {
                    X = startX;
                    Y = startY;
                    Icon = "O";
                    Color = ConsoleColor.Yellow;
                }

                public void Draw()
                {
                    Console.ForegroundColor = Color;
                    Console.SetCursorPosition(X, Y);
                    Console.Write(Icon);
                    Console.ResetColor();
                }
            }
        }

        //...
    }
}
