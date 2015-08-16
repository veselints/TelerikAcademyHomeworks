namespace P3LoverOf3
{
    using System;

    internal class LoverOf3
    {
        private static void Main()
        {
            string[] inputStrings = ReadInput(Console.ReadLine());
            int rows = int.Parse(inputStrings[0]);
            int cols = int.Parse(inputStrings[1]);
            int[,] field = BuildField(rows, cols);

            int numberOfDirections = int.Parse(Console.ReadLine());

            string[] instructions = new string[numberOfDirections];
            int[] instructionsRepetitions = new int[numberOfDirections];

            for (int i = 0; i < numberOfDirections; i++)
            {
                string[] currentDirectionInput = ReadInput(Console.ReadLine());
                instructions[i] = currentDirectionInput[0];
                instructionsRepetitions[i] = int.Parse(currentDirectionInput[1]);
            }

            int result = CalculateMovements(instructions, instructionsRepetitions, field);

            Console.WriteLine(result);
        }

        private static string[] ReadInput(string input)
        {
            char[] splitter = {' '};
            string[] inputStrings = input.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            return inputStrings;
        }

        private static int[,] BuildField(int rows, int cols)
        {
            int[,] field = new int[rows, cols];
            for (int row = rows - 1; row >= 0; row--)
            {
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = (col + rows - row - 1)*3;
                }
            }

            return field;
        }

        private static int CalculateMovements(string[] instructions, int[] instructionsRepetitions, int[,] field)
        {
            int currentX = 0;
            int currentY = field.GetLength(0) - 1;
            int result = 0;

            for (int i = 0; i < instructionsRepetitions.Length; i++)
            {
                int[] currentInstructionResult = {0, currentX, currentY};

                if (instructions[i] == "UR" || instructions[i] == "RU")
                {
                    currentInstructionResult = CalculateCurrentInstructionsResult(instructionsRepetitions[i], currentX, currentY, field, 1, -1, result);
                }
                else if (instructions[i] == "RD" || instructions[i] == "DR")
                {
                    currentInstructionResult = CalculateCurrentInstructionsResult(instructionsRepetitions[i], currentX, currentY, field, 1, 1, result);
                }
                else if (instructions[i] == "DL" || instructions[i] == "LD")
                {
                    currentInstructionResult = CalculateCurrentInstructionsResult(instructionsRepetitions[i], currentX, currentY, field, -1, 1, result);
                }
                else if (instructions[i] == "LU" || instructions[i] == "UL")
                {
                    currentInstructionResult = CalculateCurrentInstructionsResult(instructionsRepetitions[i], currentX, currentY, field, -1, -1, result);
                }

                result = currentInstructionResult[0];
                currentX = currentInstructionResult[1];
                currentY = currentInstructionResult[2];
            }

            return result;
        }


        private static int[] CalculateCurrentInstructionsResult(int instructionRepetition, int currentX, int currentY, int[,] field, int changeX, int changeY, int numberResult)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int j = 1; j < instructionRepetition; j++)
            {
                currentX += changeX;
                currentY += changeY;

                if (currentX == cols || currentY == -1 || currentX == -1 || currentY == rows)
                {
                    currentX -= changeX;
                    currentY -= changeY;
                    break;
                }

                numberResult += field[currentY, currentX];
                field[currentY, currentX] = 0;
            }

            int[] result = {numberResult, currentX, currentY};

            return result;
        }
    }
}
