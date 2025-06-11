// See https://aka.ms/new-console-template for more information
String welcomeMessage = "     Hello, Dave!     ";
string trimmedWelcome = welcomeMessage.TrimStart();
trimmedWelcome = trimmedWelcome.TrimEnd();

//can be achieved with .Trim() 

string fullTrim = welcomeMessage.Trim();


//
Console.WriteLine($"Before Trimming: [{welcomeMessage}]");
Console.WriteLine($"After Trimming: [{trimmedWelcome}]");
Console.WriteLine($"Full Trim: [{fullTrim}]");



//string firstFriend = "Maria";
//string secondFriend = "Scott";
//Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");