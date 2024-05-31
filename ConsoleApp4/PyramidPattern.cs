namespace ConsoleApp4
{
    static class PyramidPattern
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                // First inner loop for spaces
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                // Second inner loop for stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}