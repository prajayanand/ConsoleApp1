using System;

namespace ConsoleApp7
{
    class Counting
    {
        static void Main(string[] args)
        {
            // Outer loop for increment values (1 to 4)
            for (int increment = 1; increment <= 4; increment++)
            {
                // Inner loop for counting up to 24 with the current increment
                for (int i = 0; i <= 24; i += increment)
                {
                    Console.Write(i);
                    if (i + increment <= 24)
                    {
                        Console.Write(",");
                    }
                }
                // Move to the next line after each increment set
                Console.WriteLine();
            }
        }
    }
}