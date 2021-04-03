using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    class Program
    {
        public static void Main()
        {
            // Write a function that takes a filename as a parameter
            // The file contains an ended Tic-Tac-Toe match
            // We have provided you some example files (draw.txt, win-x.txt, win-o.txt)
            // Return "X", "O" or "Draw" based on the input file's content

            //Console.Write(TicTacResult("win-o.txt"));
            // Should print "O"

            //Console.Write(TicTacResult("win-x.txt"));
            // Should print "X"

            //Console.Write(TicTacResult("draw.txt"));
            // Should print "Draw"

            List<string> conditions = new List<string>();
            conditions.Add("S:\\Work\\Code\\peter-keller\\csharp-for-azam\\week-1\\day-5\\assets\\win-x.txt");
            conditions.Add("S:\\Work\\Code\\peter-keller\\csharp-for-azam\\week-1\\day-5\\assets\\win-o.txt");
            conditions.Add("S:\\Work\\Code\\peter-keller\\csharp-for-azam\\week-1\\day-5\\assets\\draw.txt");

            foreach (var condition in conditions)
            {
                TicTacResult(condition);
            }
        }

        private static void TicTacResult(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> match = new List<string>();

            while ((line = myReader.ReadLine()) != null)
            {
                var result = line;
                string[] stringArray = { result };
                match.Add(String.Join("", stringArray));
            }

            var zeroZero = match[0].Substring(0, 1);
            var zeroOne = match[0].Substring(1, 1);
            var zeroTwo = match[0].Substring(2, 1);

            var oneZero = match[1].Substring(0, 1);
            var oneOne = match[1].Substring(1, 1);
            var oneTwo = match[1].Substring(2, 1);

            var twoZero = match[2].Substring(0, 1);
            var twoOne = match[2].Substring(1, 1);
            var twoTwo = match[2].Substring(2, 1);


            List<string> players = new List<string>();
            players.Add("X");
            players.Add("O");
            var gameResult = "";
            foreach (var player in players)
            {
                // check rows
                if (zeroZero == player && zeroOne == player && zeroTwo == player) { gameResult += player; }
                if (oneZero == player && oneOne == player && oneTwo == player) { gameResult += player; }
                if (zeroTwo == player && twoOne == player && twoTwo == player) { gameResult += player; }

                // check columns
                if (zeroZero == player && oneZero == player && twoZero == player) { gameResult += player; }
                if (zeroOne == player && oneOne == player && twoOne == player) { gameResult += player; }
                if (zeroTwo == player && oneTwo == player && twoTwo == player) { gameResult += player; }

                // check diagonal
                if (zeroZero == player && oneOne == player && twoZero == player) { gameResult += player; }
                if (zeroTwo == player && oneOne == player && twoZero == player) { gameResult += player; }
            }

            switch (gameResult)
            {
                case "X":
                    Console.WriteLine("X");
                    break;
                case "O":
                    Console.WriteLine("O");
                    break;
                default:
                    Console.WriteLine("Draw");
                    break;
            }


        }
    }
}