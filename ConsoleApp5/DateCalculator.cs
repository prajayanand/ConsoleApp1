namespace ConsoleApp5
{
    class DateCalculator
    {
        static void Main(string[] args)
        {
            // Define the birth date
            DateTime birthDate = new DateTime(2000, 11, 21); //Example

            // Calculate the current date
            DateTime currentDate = DateTime.Now;

            // Calculate the number of days old
            TimeSpan ageSpan = currentDate - birthDate;
            int daysOld = ageSpan.Days;

            // Extra
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

            // Output the results
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate.ToShortDateString()}.");
        }
    }
}