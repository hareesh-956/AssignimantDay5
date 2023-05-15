namespace HeadsAndTails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of times to flip the coin: ");
            int numFlips = Convert.ToInt32(Console.ReadLine());

            if (numFlips <= 0)
            {
                Console.WriteLine("Number of flips should be a positive integer.");
                return;
            }

            int numHeads = 0;
            int numTails = 0;

            Random random = new Random();

            for (int i = 0; i < numFlips; i++)
            {
                double flipResult = random.NextDouble();

                if (flipResult < 0.5)
                {
                    numHeads++;
                }
                else
                {
                    numTails++;
                }
            }

            double percentageHeads = (double)numHeads / numFlips * 100;
            double percentageTails = (double)numTails / numFlips * 100;

            Console.WriteLine($"Percentage of Heads: {percentageHeads}%");
            Console.WriteLine($"Percentage of Tails: {percentageTails}%");
        }
    }
}