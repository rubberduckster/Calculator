namespace Program
{
    static class Program
    {
        public static void Main()
        {
            string userSelect;
            do
            {
                Console.WriteLine("Calculator\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Potency\n6. Square root\n7. Procentage\n");
                Console.Write("Type the number you wanna select: ");
                userSelect = Console.ReadLine();
                switch (userSelect)
                {
                    case "1":
                        Console.Clear();
                        Calc addition = new Calc();

                        addition.Addition();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "2":
                        Console.Clear();
                        Calc subtraction = new Calc();

                        subtraction.Subtraction();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "3":
                        Console.Clear();
                        Calc multiplication = new Calc();

                        multiplication.Multiplication();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "4":
                        Console.Clear();
                        Calc division = new Calc();

                        division.Division();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "5":
                        Console.Clear();
                        Calc potency = new Calc();

                        potency.Potency();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "6":
                        Console.Clear();
                        Calc squareRoot = new Calc();

                        squareRoot.SquareRoot();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "7":
                        Console.Clear();
                        Calc procentage = new Calc();

                        procentage.Procentage();
                        Console.WriteLine("Do you want to exit the program or do another calculation?\nPress 0 if you wanna end the program, or a number from the menu to continue.\n");
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input, try again!\n");
                        break;
                }
            } while (userSelect != "0");
        }
    }
}