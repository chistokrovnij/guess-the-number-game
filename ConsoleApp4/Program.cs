namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomValue = random.Next(1, 5);
            int inputValue;

            while (true)
            {
                Console.Write("Робот загодал число от 1 до 5, угадайте число: ");
                string userInputValue = Console.ReadLine();

                if (int.TryParse(userInputValue, out inputValue))
                {
                    if (randomValue == inputValue && inputValue <= 5 && inputValue >= 1)
                    {
                        Console.WriteLine("Вы угадали число, игра окончена!");
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали число, введите число от 1 до 5.");
                    }
                }
                else
                    Console.WriteLine("Ошибка, введите число от 1 до 5.");
            }
        }
    }
}