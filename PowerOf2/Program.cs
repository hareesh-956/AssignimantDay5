namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power value N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 0 && N < 31)
            {
                Console.WriteLine("Powers of 2 up to 2^" + N + ":");
                for (int i = 0; i <= N; i++)
                {
                    int power = (int)Math.Pow(2, i);
                    Console.WriteLine("2^" + i + " = " + power);
                }
            }
            else
            {
                Console.WriteLine("Invalid input! N should be between 0 and 30.");
            }
        }
    }
}