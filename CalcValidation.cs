namespace Calculator
{
    internal class CalcValidation
    {
        private double num1;
        private double num2;
        private char operation;

        public void Num1_Validation()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input try again!\n");
                    continue;
                }
                break;
            }
        }

        public void Num2_Validation()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Second Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input try again!\n");
                    continue;
                }
                break;
            }
        }

        public void Operation_Validation()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Operation: ");
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input try again!\n");
                    continue;
                }

                if (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != '%')
                {
                    Console.WriteLine("\nInvalid input try again!\n");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        public void Menu()
        {
            Num1_Validation();
            Console.WriteLine();
            Num2_Validation();
            Console.WriteLine();
            Operation_Validation();
            Console.WriteLine();

            CalcProcess Calc = new CalcProcess(num1, num2);

            if (operation == '+')
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + Calc.Sum());
            }
            else if (operation == '-')
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + Calc.Sub());
            }
            else if (operation == '*')
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + Calc.Multi());
            }
            else if (operation == '/')
            {
                Console.WriteLine(num1 + " / " + num2 + " = " + Calc.Div());
            }
            else if (operation == '%')
            {
                Console.WriteLine(num1 + " % " + num2 + " = " + Calc.Mod());
            }
        }
    }
}
