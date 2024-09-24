class BasicCalculator
{
    static void Main()
    {
        Calculator();
    }

    public static void Calculator()
    {
        Console.WriteLine("Welcome to the Calculator. Please enter any key to start, or 'e' to exit.");

        string? userInput = Console.ReadLine();

        // Continue as long as the user does not input 'e' to exit
        while (userInput != "e")
        {
            Console.WriteLine("Please enter a number.");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Enter operator (+ - * /).");
            string? op = Console.ReadLine();

            Console.WriteLine("Please enter a second number.");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        if (num1 > 0)
                        {
                            Console.WriteLine("A number cannot be divided by 0, but the result tends to infinity.");
                        }
                        else
                        {
                            Console.WriteLine("A number cannot be divided by 0, but the result tends to negative infinity.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Error. Please enter a correct operator (+ - * /).");
                    continue;
            }

            string? restartInput;
            do
            {
                Console.WriteLine("Please press 'y' to restart, 'e' to exit, or any other key to retry.");
                restartInput = Console.ReadLine();

                if (restartInput == "e")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return; // Exit the method and program
                }
                else if (restartInput == "y")
                {
                    Console.WriteLine("Restarting the calculator.");
                    break; // Restart the loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' to restart or 'e' to exit.");
                }
            } while (restartInput != "y" && restartInput != "e");
        }

        Console.WriteLine("Exiting the calculator. Goodbye!");
    }
}
