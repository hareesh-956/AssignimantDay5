namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its prime factors: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + N + ":");

            // Traverse until i*i <= N for efficiency
            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }

            // If N is greater than 1, it is a prime factor
            if (N > 1)
            {
                Console.WriteLine(N);
            }
        }
    }
}