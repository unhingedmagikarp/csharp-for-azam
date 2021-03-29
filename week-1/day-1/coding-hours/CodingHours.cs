using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52


            var codeHoursDaily = 6;
            var semester = 17;
            var workDaysOnlySemester = 5 * semester;
            var hoursSpentCoding = codeHoursDaily * workDaysOnlySemester;

            Console.WriteLine("Hours spend coding: " + hoursSpentCoding);

            var longHoursDaily = 52 / 5;
            var longHoursSpentCoding = longHoursDaily * workDaysOnlySemester;

            //what do i do here, i give up
            var percentageOfLongCodingHours = 0;



            Console.ReadLine();
        }
    }
}
