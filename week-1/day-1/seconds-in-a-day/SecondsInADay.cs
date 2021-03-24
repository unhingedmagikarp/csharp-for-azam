using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above
            int totalSecondsInDay = 86400;

            int remainingSecondsFromMinutes = currentMinutes * 60;
            int remainingSecondsFromHours = currentHours * 3600;

            int remainingSecondsFromDay = totalSecondsInDay - remainingSecondsFromHours - remainingSecondsFromMinutes - currentSeconds;

            Console.WriteLine("Remaining Seconds: " + remainingSecondsFromDay);
        }
    }
}
