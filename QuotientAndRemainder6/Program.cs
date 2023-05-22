namespace QuotientAndRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a divident: ");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");


        }
    }
}