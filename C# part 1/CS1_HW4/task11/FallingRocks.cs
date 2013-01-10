using System;
using System.Collections.Generic;
using System.Threading;

namespace FallingRocksGame
{
    class FallingRocks
    {
        
        #region Variables
        
        static char[] rockType =
        {
            ' ', '!', '@', '#', '$', '%', '^', '&', '*', '+', '.', ';'
        };
        
        static ConsoleColor[] colours = 
        {
            ConsoleColor.White,
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
            ConsoleColor.Green,
            ConsoleColor.Magenta,
            ConsoleColor.Blue
        };
        
        static Player playerX = new Player();
        static List<Rock> listOfRocks = new List<Rock>();
        static byte timeToMoveRocks = 0;
        static byte timeToAddRock = 0;
        static Random randomNumber = new Random();
        static int score = 0;
        static byte difficulty = 5;

        #endregion
        
        public class Rock
        {
            private char type;
            private ConsoleColor rockColor;
            private int size;
            private int positionX;
            private int positionY;
            
            public Rock()
            {
                type = rockType[0];
                rockColor = colours[0];
                size = 1;
                positionX = 1;
                positionY = 1;
            }
            
            public int SetSize
            {
                set
                {
                    size = value;
                }
            }
            
            public int SetPositionX
            {
                set
                {
                    positionX = value;
                }
            }
            
            public int SetPositionY
            {
                set
                {
                    positionY = value;
                }
            }
            
            public char SetType
            {
                set
                {
                    type = value;
                }
            }
            
            public void Draw()
            {
                if (positionY >= 0 && positionY + size <= Console.WindowWidth - 1)
                {
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ForegroundColor = (ConsoleColor)rockColor;
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(type);
                    }
                    Console.ResetColor();
                }
            }
            
            public void MoveDown()
            {
                if (positionY < Console.WindowHeight - 1)
                {
                    positionY++;
                }
            }
            
            public int GetPositionY
            {
                get
                {
                    return positionY;
                }
            }
            
            public ConsoleColor SetColor
            {
                set
                {
                    rockColor = value;
                }
            }
            
            public int GetPositionX
            {
                get
                {
                    return positionX;
                }
            }
            
            public int GetSize
            {
                get
                {
                    return size;
                }
            }
        }
        
        public class Player
        {
            private int playerPosition;
            private int playerSize;
            private ConsoleColor playerColor;
            
            public Player()
            {
                playerPosition = 1;
                playerSize = 1;
                playerColor = colours[0];
            }
            
            public int GetAndSetPosition
            {
                get
                {
                    return playerPosition;
                }
                set
                {
                    playerPosition = value;
                }
            }
            
            public int SetSize
            {
                set
                {
                    playerSize = value;
                }
            }
            
            public void MoveRight()
            {
                if (playerPosition + playerSize + 1 < Console.WindowWidth - 1)
                {
                    playerPosition++;
                }
            }
            
            public void MoveLeft()
            {
                if (playerPosition > 0)
                {
                    playerPosition--;
                    return;
                }
            }
            
            public void Draw()
            {
                Console.SetCursorPosition(playerPosition, Console.WindowHeight - 2);
                Console.ForegroundColor = (ConsoleColor)playerColor;
                Console.Write("(");
                for (int i = 0; i < playerSize; i++)
                {
                    Console.Write("O");
                }
                Console.Write(")");
                Console.ResetColor();
            }
            
            public int GetSize
            {
                get
                {
                    return playerSize;
                }
            }
        }

        #region Functions
        
        static void SetWindowSize()
        {
            Console.WindowWidth = 60;
            Console.WindowHeight = 50;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
        }
        
        static void DrawPlayer()
        {
            playerX.Draw();
        }
        
        static void SetPlayerDefaultPositions()
        {
            playerX.GetAndSetPosition = Console.WindowWidth / 2 - playerX.GetSize / 2 - 1;
        }
        
        static void DrawRocks()
        {
            listOfRocks.RemoveAll(item => item.GetPositionY == Console.WindowHeight - 1);
            
            foreach (Rock item in listOfRocks)
            {
                item.Draw();
            }
        }
        
        static Rock NewRandomRock()
        {
            Rock randomRock = new Rock();
            randomRock.SetType = rockType[randomNumber.Next(1, 12)];
            randomRock.SetColor = colours[randomNumber.Next(1, 7)];
            randomRock.SetSize = randomNumber.Next(1, 6);
            randomRock.SetPositionX = randomNumber.Next(0, Console.WindowWidth - 1);
            return randomRock;
        }
        
        static void GameOver()
        {
            Console.Clear();
            listOfRocks.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
            Console.Write("Game Over");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1);
            Console.Write("Score: {0}", score);
            score = 0;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 2);
            Console.Write("Start new game y/n ?: ");
            Thread.Sleep(2000);
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y" || answer == "yes" || answer == "Yes")
            {
                StartGame();
            }
            else
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Environment.Exit(0);
            }
            //ConsoleKeyInfo pressedKey = Console.ReadKey();
            //if (pressedKey.Key == ConsoleKey.Y)
            //{
            //    StartGame();
            //}
            //if (pressedKey.Key == ConsoleKey.N)
            //{
            //    Console.SetCursorPosition(0, Console.WindowHeight - 1);
            //    Environment.Exit(0);
            //}
        }
        
        static void StartGame()
        {
            Console.Clear();
            SelectDifficulty();
            listOfRocks.Clear();
            SetPlayerDefaultPositions();
            timeToAddRock = 0;
            timeToMoveRocks = 0;
            while (true)
            {
                timeToMoveRocks++;
                timeToAddRock++;
                if (timeToAddRock == difficulty * 4)
                {
                    listOfRocks.Add(NewRandomRock());
                    timeToAddRock = 0;
                }
                
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        playerX.MoveLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        playerX.MoveRight();
                    }
                }
                Console.Clear();
                DrawPlayer();
                DrawRocks();
                if (timeToMoveRocks % difficulty == 0)
                {
                    foreach (Rock item in listOfRocks)
                    {
                        if (item.GetPositionY == Console.WindowHeight - 2 &&
                            (item.GetPositionX + item.GetSize - 1) >= playerX.GetAndSetPosition &&
                            item.GetPositionX <= (playerX.GetAndSetPosition + playerX.GetSize + 1))
                        {
                            GameOver();
                            return;
                        }
                        else
                        {
                            item.MoveDown();
                        }
                    }
                }
                score++;
                Thread.Sleep(30);
            }
        }
        
        static void SelectDifficulty()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
            Console.Write("Select difficulty");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 + 2);
            Console.Write("5   4   3   2   1");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, Console.WindowHeight / 2 + 3);
            Console.Write("Easy            Hard");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 4);
            Console.Write("Enter number: ");
            bool parseSuccesses = byte.TryParse(Console.ReadLine(), out difficulty);
            if (difficulty == 0)
            {
                difficulty = 5;
            }
            if (!parseSuccesses)
            {
                difficulty = 5;
            }
            Console.Clear();
        }

        #endregion
        
        static void Main(string[] args)
        {
            Console.Title = "Falling Rocks";
            SetWindowSize();
            StartGame();
        }
    }
}