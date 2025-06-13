//decimal min/max

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

// decimal higher precision

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

//C# Learn challenge

double P = Math.PI;
double r = 2.50;

double Area = Math.Round(P * (r * r),3);

Console.WriteLine($" area of circle  with radius {r} = {Area}");
