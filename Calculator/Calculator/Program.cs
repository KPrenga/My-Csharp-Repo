using System.Text.RegularExpressions;
using CalculatorLibrary.cs;


class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        //title
        string title = "Console App Calculator \r";
        Console.WriteLine(title);
        Console.WriteLine(new string('-', title.Length) + "\n");

        Calculator calculator= new Calculator();    

        while (!endApp)
        {
            //declare variables as empty and nullable(?)
            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            //ask for first number
            Console.WriteLine("Type a number and press enter");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1)) //while not double, locked in until it is format double
            {
                Console.Write("Incorrect input, Please enter a numerical value");
                numInput1 = Console.ReadLine();
            }

            Console.WriteLine("Type a number and press enter");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2)) //while not double, locked in until it is format double
            {
                Console.Write("Incorrect input, Please enter a numerical value");
                numInput2 = Console.ReadLine();
            }

            //choose operator
            Console.WriteLine(@"Choose an operation from the list
            a - Add
            s - Subtract
            m - Multiply
            d - Divide
            ");
            Console.Write("Your option? ");

            string? op = Console.ReadLine();

            //check for null and match
            if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: Unrecognised Input");
            }
            else
            {
                try
                {
                    result = calculator.DoCalculation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Operation results in mathmatical error\n");
                    }
                    else Console.WriteLine($"Your result: {result} ");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: ", e.Message);
                }
            }
            Console.WriteLine("------------------------\n");

            //wait for response from user
            Console.Write("Press 'n' and Enter to close the app, or another key to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");

        }
        return;
    }
}