namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1; // Assume num1 is the largest initially

            // Compare num2 with current largest
            if (num2 > largest)
            {
                largest = num2;
            }

            // Compare num3 with current largest
            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine("The largest number is: " + largest);
        }
    }
}