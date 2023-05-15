namespace AssignimentDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a year");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 2000 || x < 1000)
            {
                Console.WriteLine(" please enter four digit year ");
            }
            else if ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year.", x);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", x);

            }
        }
    }
}