namespace Challenge_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }
        static void Countdown(int number)
        {
            if (number > 0)
            {
                Console.WriteLine(number);
                Countdown(number - 1);
            }
            else
            {
                Console.WriteLine("Liftoff!");
            }

        }
    }
}
