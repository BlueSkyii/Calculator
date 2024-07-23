using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            do
            {
                double x = 0;
                double y = 0;
                String ope = "";

                calcShape();

                getNum(ref x, 1);
                getNum(ref y, 2);
                getOpe(ref ope);

                calcProcess(x, y, ope);

                Console.WriteLine();

                Console.Write("Enter ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1 ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("to try again");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tOR");
                Console.WriteLine();
                Console.Write("Enter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Any other number ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("to exist");
                Console.WriteLine();
                Console.WriteLine();

                while (true)
                {
                    try
                    {
                        c = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a Number!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        continue;
                    }
                    break;
                }

                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(700);
                Console.Clear();
                Thread.Sleep(300);

            } while (c == 1);
        }

        static void calcShape() {
            Console.WriteLine("--------------------------------");

            Console.Write("1\t");
            Console.Write("2\t");
            Console.Write("3   ");
            Console.Write("|   ");
            Console.Write("+   ");
            Console.Write("/  ");
            Console.Write("|");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("4\t");
            Console.Write("5\t");
            Console.Write("6   ");
            Console.Write("|   ");
            Console.Write("-   ");
            Console.Write("%  ");
            Console.Write("|");


            Console.WriteLine();
            Console.WriteLine();

            Console.Write("7\t");
            Console.Write("8\t");
            Console.Write("9   ");
            Console.Write("|   ");
            Console.Write("*   ");
            Console.Write("=  ");
            Console.WriteLine("|");
            Console.Write("--------------------------------");

            Console.WriteLine();
        }

        static void getOpe(ref String ope) {
            bool flag = false;

            Console.Write("Enter operation : ");
            ope = Console.ReadLine();
            Console.WriteLine();

            while (flag == false)
            {
                if (ope.Length > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Enter operation again : ");
                    ope = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    if (ope != "+" && ope != "-" && ope != "*" && ope != "/" && ope != "%")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter operation again : ");
                        ope = Console.ReadLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
        }

        static void getNum(ref double num,int n) {
            string m = n==1 ? "1st":"2nd";
            while (true)
            {
                try {
                    Console.Write($"Enter {m} number : ");
                    num = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception e) {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input please enter again!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }
                break;
            }            
        }

        static void calcProcess(double x,double y,String ope) { 
            Calc c = new Calc(x, y);

            Console.ForegroundColor= ConsoleColor.Green;

            if (ope == "+")
            {
                Console.WriteLine(x + " " + ope + " " + y + " = " + c.Sum());
            }
            else if (ope == "-")
            {
                Console.WriteLine(x + " " + ope + " " + y + " = " + c.Sub());
            }
            else if (ope == "*")
            {
                Console.WriteLine(x + " " + ope + " " + y + " = " + c.Mult());
            }
            else if (ope == "/")
            {
                Console.WriteLine(x + " " + ope + " " + y + " = " + c.Div());
            }
            else {
                Console.WriteLine(x + " " + ope + " " + y + " = " + c.Mod());
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
