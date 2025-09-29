//initialise variables as zero
double num1 = 0; double num2 = 0;

string title = "Console Calculator in C#\r";
Console.WriteLine(title);
Console.WriteLine(new string('-', title.Length) + "\n");

//user input of first number
Console.WriteLine("Type a number, then press enter");
num1 = Convert.ToDouble(Console.ReadLine());

//user input of second number
Console.WriteLine("Type another number, then press enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(@"Choose an option from the following list:
a - Add
s - Subtract
m - Multiply
d - Divide");
Console.Write("Your option?\n");

//operator select
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} x {num2} = " + (num1 * num2));
        break;
    case "d":
        //check for zero divisor
        while (num2 == 0)
        {
            //ask for a different divisor
            Console.WriteLine("Enter a non-zero divisor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} ÷ {num2} = " + (num1 / num2));
        break;
}

//doorstop for exit
Console.Write("Press any key to exit the Calculator Program");
Console.ReadLine();