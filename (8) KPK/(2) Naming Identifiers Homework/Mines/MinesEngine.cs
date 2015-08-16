namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class MinesEngine
    {
        public static void Main()
        {
            string command = string.Empty;
            char[,] board = DrowElementsOnTheBoard('?');
            char[,] bombsPositions = PositionBombs();
            int currentPlayerPoints = 0;
            bool explosion = false;
            List<PlayerPoints> playersPoints = new List<PlayerPoints>(6);
            int currentRow = 0;
            int currentCol = 0;
            bool stateStartOfTheGame = true;
            int pointsToBeObtained = MinesConstants.PointsToBeObtained;
            bool gameWon = false;

            do
            {
                if (stateStartOfTheGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrowBoard(board);
                    stateStartOfTheGame = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out currentRow) &&
                        int.TryParse(command[2].ToString(), out currentCol) &&
                        currentRow <= board.GetLength(0) && currentCol <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighscore(playersPoints);
                        break;
                    case "restart":
                        board = DrowElementsOnTheBoard('?');
                        bombsPositions = PositionBombs();
                        DrowBoard(board);
                        explosion = false;
                        stateStartOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombsPositions[currentRow, currentCol] != '*')
                        {
                            if (bombsPositions[currentRow, currentCol] == '-')
                            {
                                YourTurn(board, bombsPositions, currentRow, currentCol);
                                currentPlayerPoints++;
                            }

                            if (pointsToBeObtained == currentPlayerPoints)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                DrowBoard(board);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (explosion)
                {
                    DrowBoard(bombsPositions);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. Daj si niknejm: ", currentPlayerPoints);

                    // Similar at the next case
                    string yourName = Console.ReadLine();
                    PlayerPoints yourPoints = new PlayerPoints(yourName, currentPlayerPoints);
                    if (playersPoints.Count < 5)
                    {
                        playersPoints.Add(yourPoints);
                    }
                    else
                    {
                        for (int i = 0; i < playersPoints.Count; i++)
                        {
                            if (playersPoints[i].Points < yourPoints.Points)
                            {
                                playersPoints.Insert(i, yourPoints);
                                playersPoints.RemoveAt(playersPoints.Count - 1);
                                break;
                            }
                        }
                    }

                    playersPoints.Sort((PlayerPoints playerScore1, PlayerPoints playerScore2) => playerScore2.Name.CompareTo(playerScore1.Name));
                    playersPoints.Sort((PlayerPoints playerScore1, PlayerPoints playerScore2) => playerScore2.Points.CompareTo(playerScore1.Points));
                    ShowHighscore(playersPoints);

                    board = DrowElementsOnTheBoard('?');
                    bombsPositions = PositionBombs();
                    currentPlayerPoints = 0;
                    explosion = false;
                    stateStartOfTheGame = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrowBoard(bombsPositions);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string yourName = Console.ReadLine();
                    PlayerPoints yourPoints = new PlayerPoints(yourName, currentPlayerPoints);
                    playersPoints.Add(yourPoints);
                    ShowHighscore(playersPoints);

                    board = DrowElementsOnTheBoard('?');
                    bombsPositions = PositionBombs();
                    currentPlayerPoints = 0;
                    gameWon = false;
                    stateStartOfTheGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ShowHighscore(List<PlayerPoints> playersPoints)
        {
            Console.WriteLine("\nTo4KI:");

            if (playersPoints.Count > 0)
            {
                for (int i = 0; i < playersPoints.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, playersPoints[i].Name, playersPoints[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bonbsPositions, int row, int col)
        {
            char numberOfBombs = CountBombs(bonbsPositions, row, col);
            bonbsPositions[row, col] = numberOfBombs;
            field[row, col] = numberOfBombs;
        }

        private static void DrowBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] DrowElementsOnTheBoard(char character)
        {
            int rows = MinesConstants.RowConstant;
            int cols = MinesConstants.ColConstant;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = character;
                }
            }

            return board;
        }

        private static char[,] PositionBombs()
        {
            var board = DrowElementsOnTheBoard('-');
            int cols = MinesConstants.ColConstant;

            List<int> randomNumbersCollection = new List<int>();
            Random random = new Random();
            while (randomNumbersCollection.Count < MinesConstants.CountOfRandomNumbers)
            {
                int currentRandom = random.Next(MinesConstants.RandomRange);
                if (!randomNumbersCollection.Contains(currentRandom))
                {
                    randomNumbersCollection.Add(currentRandom);
                }
            }

            foreach (int randomNumber in randomNumbersCollection)
            {
                int col = randomNumber / cols;
                int row = randomNumber % cols;
                if (row == 0 && randomNumber != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        ////This method is not called!!!
        ////private static void calculations(char[,] board)
        ////{
        ////    int rows = board.GetLength(0);
        ////    int cols = board.GetLength(1);
        ////    for (int i = 0; i < rows; i++)
        ////    {
        ////        for (int j = 0; j < cols; j++)
        ////        {
        ////            if (board[i, j] != '*')
        ////            {
        ////                char currentBombsCount = CountBombs(board, i, j);
        ////                board[i, j] = currentBombsCount;
        ////            }
        ////        }
        ////    }
        ////}

        private static char CountBombs(char[,] board, int givenRow, int givenCol)
        {
            int count = 0;

            count += CheckIfBombIsPlaced(board, givenRow - 1, givenCol);
            count += CheckIfBombIsPlaced(board, givenRow, givenCol - 1);
            count += CheckIfBombIsPlaced(board, givenRow + 1, givenCol);
            count += CheckIfBombIsPlaced(board, givenRow, givenCol + 1);
            count += CheckIfBombIsPlaced(board, givenRow - 1, givenCol - 1);
            count += CheckIfBombIsPlaced(board, givenRow - 1, givenCol + 1);
            count += CheckIfBombIsPlaced(board, givenRow + 1, givenCol - 1);
            count += CheckIfBombIsPlaced(board, givenRow + 1, givenCol + 1);

            return char.Parse(count.ToString());
        }

        private static int CheckIfBombIsPlaced(char[,] currentBoard, int rowToBeChecked, int colToBeCheked)
        {
            if (rowToBeChecked >= 0 && rowToBeChecked < MinesConstants.RowConstant &&
                colToBeCheked >= 0 && colToBeCheked < MinesConstants.ColConstant)
            {
                if (currentBoard[rowToBeChecked, colToBeCheked] == '*')
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
