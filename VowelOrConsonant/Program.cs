namespace VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());

            if (IsVowel(alphabet))
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
        }

        static bool IsVowel(char alphabet)
        {
            return alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u';
        }
    }
}