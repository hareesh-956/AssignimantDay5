namespace HarmonicNumber4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                double harmonic = 0.0;

                for (int i = 1; i <= N; i++)
                {
                    harmonic += 1.0 / i;
                }

                Console.WriteLine("The " + N + "th harmonic value is: " + harmonic);
            }
            else
            {
                Console.WriteLine("Invalid input! N must be non-zero.");
            }
        }
    }
}