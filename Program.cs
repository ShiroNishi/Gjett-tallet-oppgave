namespace Gjett_tallet
{
    internal class Program
    {
        int random = new Random().Next(1, 101);

        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Gjett et tall mellom 1 og 100");
            int number = GuessNumber();
            var result = CompareNums(number, random);
        }

        static int GuessNumber()
        {   
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        static string CompareNums(int number, int random)
        {
            if (number == random)
            {
                return $"Du vant! Tallet var {random}";
            }
            else if (number < random)
            {
                return "Lavere";
            }
            else if (number > random)
            {
                return "Høyere";
            }
            return "";
        }
    }
}
