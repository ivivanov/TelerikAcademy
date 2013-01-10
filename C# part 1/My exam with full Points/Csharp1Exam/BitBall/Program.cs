using System;

namespace BitBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] inputTeamOne = new string[8,8];
            string[,] inputTeamTwo = new string[8,8];
            string[,] grid = new string[8, 8];

            for (int row = 0; row < 8; row++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    if ((inputNumber & (1 << col)) == 1 << col)
                    {
                        inputTeamOne[row, col] = "T";
                    }
                }
            }

            for (int row = 0; row < 8; row++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    if ((inputNumber & (1 << col)) == 1 << col)
                    {
                        inputTeamTwo[row, col] = "B";
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (inputTeamOne[i, j] == "T")
                    {
                        grid[i, j] = "T";
                    }
                    else
                    {
                        if (inputTeamTwo[i, j] == "B")
                        {
                            grid[i, j] = "B";
                        }
                    }
                    if (inputTeamOne[i, j] == "T" && inputTeamTwo[i, j] == "B")
                    {
                        grid[i, j] = null;
                    }
                }
            }
            int teamOneScore = 0;
            int teamTwoScore = 0;
            int verticalPosition=0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grid[i, j] == "T")
                    {
                        if (i == 7)
                        {
                            teamOneScore++;
                        }
                        else
                        {
                            verticalPosition = i + 1;
                            while (grid[verticalPosition, j] == null)
                            {
                                if (verticalPosition == 7)
                                {
                                    teamOneScore++;
                                    break;
                                }
                                verticalPosition++;
                                if (verticalPosition > 7)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (grid[i, j] == "B")
                        {
                            if (i == 0)
                            {
                                teamTwoScore++;
                            }
                            else
                            {
                                verticalPosition = i - 1;
                                while (grid[verticalPosition, j] == null)
                                {

                                    if (verticalPosition == 0)
                                    {
                                        teamTwoScore++;
                                        break;
                                    }
                                    verticalPosition--;
                                    if (verticalPosition < 0)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }




            Console.WriteLine("{0}:{1}",teamOneScore,teamTwoScore);
            //////////matrix print
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write("{0} ",inputTeamOne[i, j]);
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write("{0} ", inputTeamTwo[i, j]);
            //    }
            //}
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 8; j++)
                {
                    if (grid[i, j] == null)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write("{0}", grid[i, j]);
                    }
                }
            }

            //////////////
        }
    }
}
