using System.Text;

namespace Assignment_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evenNumbers = EvenNumbers();
            Console.WriteLine(evenNumbers);

            int year = 2024;
            bool leap = LeapYear(year);
            Console.WriteLine(leap);

            Console.WriteLine("Please input a string: ");
            string userInput = Console.ReadLine();

            int spaces = CountSpaces(userInput);
            Console.WriteLine(spaces);
        }

        public static string EvenNumbers()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 2; i < 100; i += 2)
            {
                result.Append(i);
                if (i < 98) 
                    result.Append(", ");
            }
            return result.ToString();
        }

        public static bool LeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public static int CountSpaces(string input)
        {
            string[] words = input.Split(' ');
            int spaceCount = words.Length - 1;
            return spaceCount;
        }
    }
}
