namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0, secondNumber = 0;
            int selectAction = 0;

            do
            {
                Console.WriteLine("What operation do you want to perform?");
                Console.WriteLine("1-Add\n2-Subtract\n3-Multiply\n4-Divide\n5-Exit");

                if (!int.TryParse(Console.ReadLine(), out selectAction) || selectAction < 1 || selectAction > 5)
                {
                    Console.WriteLine("Invalid input. Please select a valid operation (1-5).");
                    continue;
                }

                if (selectAction == 5)
                {
                    Console.WriteLine("Goodbye...");
                    break;
                }

                Console.WriteLine("Enter your first number:");
                if (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter your second number:");
                if (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (selectAction)
                {
                    case 1:
                        Console.WriteLine($"The sum of {firstNumber} + {secondNumber} is: {firstNumber + secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"The subtraction of {firstNumber} - {secondNumber} is: {firstNumber - secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"The multiplication of {firstNumber} * {secondNumber} is: {firstNumber * secondNumber}");
                        break;
                    case 4:
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Sorry, you cannot divide by 0. Please try again.");
                        }
                        else
                        {
                            Console.WriteLine($"The division of {firstNumber} / {secondNumber} is: {firstNumber / secondNumber}");
                        }
                        break;
                    default:
                        Console.WriteLine("You have not chosen a valid option.");
                        break;
                }
            } while (true);
        }
    }
}
