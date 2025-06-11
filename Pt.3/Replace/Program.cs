// See https://aka.ms/new-console-template for more information
string sayHello = "Hello, World!";
Console.WriteLine(sayHello);


// Replace looks for string in primary position
// and replaces it with the string in the secondary position

string replacedHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(replacedHello);

//using replace with usr input (pure curiosity)

Console.WriteLine("Type something");
// Exclamation mark is apparently a null forgiving operator
// i did not know this till now
string input = Console.ReadLine()!;

sayHello = sayHello.Replace("Hello", input);
Console.WriteLine(sayHello);
