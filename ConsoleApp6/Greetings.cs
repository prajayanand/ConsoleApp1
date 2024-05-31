using System;

namespace ConsoleApp6
{
    class Greetings
    {
        static void Main(string[] args)
        {
            // With using Example Time
            // DateTime currentTime = new DateTime(2024, 5, 30, 14, 30, 0); // 2:30 PM

            // To get current time
            DateTime currentTime = DateTime.Now;

            int currentHour = currentTime.Hour;
            if (currentHour >= 5 && currentHour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (currentHour >= 12 && currentHour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (currentHour >= 17 && currentHour < 21)
            {
                Console.WriteLine("Good Evening");
            }

            if ((currentHour >= 21 && currentHour < 24) || (currentHour >= 0 && currentHour < 5))
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}