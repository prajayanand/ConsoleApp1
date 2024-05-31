using System;

namespace ConsoleApp1 
{
    public class CenturyConverter4
    {
        public static void Main(string[] args)
        {
            // Ask for user input
            Console.Write("Enter number of centuries: ");
            string input = Console.ReadLine();

            // Check if the input is not null
            if (input != null && int.TryParse(input, out int centuries))
            {
                // Convert centuries to other units
                int years = centuries * 100;
                long days = (long)(years * 365.24);
                long hours = days * 24;
                long minutes = hours * 60;
                long seconds = minutes * 60;
                long milliseconds = seconds * 1000;
                long microseconds = milliseconds * 1000;
                decimal nanoseconds = (decimal)microseconds * 1000;

                // Display the results
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of centuries.");
            }
        }
    }
}