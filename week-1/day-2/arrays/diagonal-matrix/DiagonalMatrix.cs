using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array dynamically with the following content.
            //   Note that a two dimensional array is often called matrix if every
            //   internal array has the same length.
            //   Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            //   Its length should depend on a variable
            //  
            // - Print this two dimensional array to the output

            int rows = 4;
            int columns = 4;

            int[,] myMatrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    myMatrix[row, column] = rows;
                }
            }

            Console.Write(myMatrix);
        }
    }
}
