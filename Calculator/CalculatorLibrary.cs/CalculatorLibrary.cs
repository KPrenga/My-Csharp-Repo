namespace CalculatorLibrary.cs;

using System.Diagnostics;

public class Calculator
{
    public Calculator()
    {
        StreamWriter logFile = File.CreateText("calculator.log");
        Trace.Listeners.Add(new TextWriterTraceListener(logFile));
        Trace.AutoFlush = true;
        Trace.WriteLine("Starting Calculator Log");
        Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
    }

    public double DoCalculation(double num1, double num2, string op)
    {
        double result = double.NaN; // value set as no a number incase operation results in error

        //switch for operation selection

        switch (op)
        {
            case "a":
                result = num1 + num2;
                Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                break;
            case "s":
                result = num1 - num2;
                Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
                break;
            case "m":
                result = num1 * num2;
                Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
                }
                break;
            default:
                Console.WriteLine("Please select a valid operation: ");
                break;
        }

        return result;
    }
}

