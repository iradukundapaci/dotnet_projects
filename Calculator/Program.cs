using CalculatorNamespace;

Calculator calculator = new Calculator();

while (true)
{
    Console.Write("Enter operation number:\n 1 Addition\n 2 Subtraction\n 3 Multiplication\n 4 Division\n 0 EXIT\n Choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice <= 0)
    {
        Console.WriteLine("Exiting program");
        break;
    }
    else if (choice > 4)
    {
        Console.WriteLine("Unkown Choice \n");
        continue;
    }
    Console.Write("Enter first operand: ");
    float firstOperand = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second operand: ");
    float secondOperand = Convert.ToInt32(Console.ReadLine());


    switch (choice)
    {
        case 1:
            Console.Write("\nThe result is " + calculator.addition(firstOperand, secondOperand) + "\n\n");
            break;
        case 2:
            Console.Write("\nThe result is " + calculator.subtraction(firstOperand, secondOperand) + "\n\n");
            break;
        case 3:
            Console.Write("\nThe result is " + calculator.multiplication(firstOperand, secondOperand) + "\n\n");
            break;
        case 4:
            if (secondOperand == 0)
            {
                Console.WriteLine("Division by zero is impossible");
                break;
            }
            Console.Write("\nThe result is " + calculator.division(firstOperand, secondOperand) + "\n\n");
            break;
    }
}
