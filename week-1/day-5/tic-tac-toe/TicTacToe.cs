using System;

namespace PracticeTask
{
  class Program
  {
    static void Main(string[] args)
    {
      // Write a function that takes a filename as a parameter
      // The file contains an ended Tic-Tac-Toe match
      // We have provided you some example files (draw.txt, win-x.txt, win-o.txt)
      // Return "X", "O" or "Draw" based on the input file's content

      Console.Write(TicTacResult("win-o.txt"));
      // Should print "O"

      Console.Write(TicTacResult("win-x.txt"));
      // Should print "X"

      Console.Write(TicTacResult("draw.txt"));
      // Should print "Draw"
    }
  }
}
