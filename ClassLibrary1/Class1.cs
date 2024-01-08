namespace OptionsProgram
{
    public class Options
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool ValidateNumberNatural(int number)
        {
            return number > 0;
        }
        public static int CalculatePower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        public static int RandomNumber(int rangmin, int rangmax)
        {
            Random random = new Random();
            return random.Next(rangmin, rangmax);
        }
        public static int CountVowels(string text)
        {
            int count = 0;
            foreach (char letter in text)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
