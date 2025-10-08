namespace CalculatorLibrary.cs;

public class Calculator
{

    public static double DoCalculation(double num1, double num2, string op)
    {
        double result = double.NaN; // value set as no a number incase operation results in error

        //switch for operation selection

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Please select a valid operation: ");
                break;
        }

        return result;
    }
}

