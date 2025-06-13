// See https://aka.ms/new-console-template for more information


//example of int truncationg div result
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
//% to get remainder
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

//int range min/max

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers ins {min} to {max}");

//overflow example

int overflow = max + 5;
Console.WriteLine($"Overflow Example: {overflow}");

//underflow example
int underflow = min - 5;
Console.WriteLine($"Underflow example: {underflow}");

//int is circular
//going past the limit sends you around, past the other limit 