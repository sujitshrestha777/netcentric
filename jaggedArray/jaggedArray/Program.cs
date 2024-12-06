using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] calendarView = new int[12][]; // 12 months

            // Initialize each month with a varying number of days
            calendarView[0] = new int[31]; // January 
            calendarView[1] = new int[28]; // February 
            calendarView[2] = new int[31]; // March 
            calendarView[3] = new int[30]; // April 
            calendarView[4] = new int[31]; // May 
            calendarView[5] = new int[30]; // June 
            calendarView[6] = new int[31]; // July
            calendarView[7] = new int[31]; // August 
            calendarView[8] = new int[30]; // September 
            calendarView[9] = new int[31]; // October 
            calendarView[10] = new int[30]; // November 
            calendarView[11] = new int[31]; // December 

            // Add events or appointments to the calendar
            calendarView[0][0] = 1;  // Event on January 1st
            calendarView[1][13] = 2; // Event on February 14th
            calendarView[2][19] = 3; // Event on March 20th

            // Access and display events in the calendar
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < calendarView[month].Length; day++)
                {
                    if (calendarView[month][day] > 0) // Check if an event is present
                    {
                        Console.WriteLine($"Event on {month + 1}/{day + 1}");
                    }
                }
            }
        }
    }
}

