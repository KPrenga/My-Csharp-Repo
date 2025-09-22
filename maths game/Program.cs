// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.Design;
String tick = "✔";

Queue<string> Questions = new Queue<string>();


while (true)
{
    MenuMethod();
}


void AdditionGame(string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < 3;)
    {
        int rnd1, rnd2;
        RandomNumGen(out rnd1, out rnd2);

        int sum = rnd1 + rnd2;

        Console.WriteLine($"{rnd1} + {rnd2}");
        int Answer = Convert.ToInt32(Console.ReadLine());
        if (Answer == sum)
        {
            Console.WriteLine($"{tick} That is Correct!");
            Questions.Enqueue($"{rnd1} + {rnd2} = {Answer} {tick}");
        }
        else
        {
            Console.WriteLine(@$"X  Oops, That is Incorrect
        The Answer was {sum}
        
        ");
        Questions.Enqueue($"{rnd1} + {rnd2} = {Answer} X  Answer: {sum}");
            i++;
        }
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < 3;)
    {

        int rnd1, rnd2;
        RandomNumGen(out rnd1, out rnd2);
        int sum = rnd1 - rnd2;

        Console.WriteLine($"{rnd1} - {rnd2}");
        int Answer = Convert.ToInt32(Console.ReadLine());
        if (Answer == sum)
        {
            Console.WriteLine("That Is Correct!");
            Questions.Enqueue($"{rnd1} - {rnd2} = {Answer} {tick}");
        }
        else
        {
            Console.WriteLine(@$"Oops, That is Incorrect
        The Answer was {sum}
        ");
        Questions.Enqueue($"{rnd1} - {rnd2} = {Answer} X  Answer: {sum}");
            i++;
        }
    }
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < 3;)
    {
        int rnd1, rnd2;
        RandomNumGen(out rnd1, out rnd2);
        int sum = rnd1 * rnd2;

        Console.WriteLine($"{rnd1} x {rnd2}");
        int Answer = Convert.ToInt32(Console.ReadLine());
        if (Answer == sum)
        {
            Console.WriteLine("That Is Correct!");
            Questions.Enqueue($"{rnd1} x {rnd2} = {Answer} {tick}");
        }
        else
        {
            Console.WriteLine(@$"Oops, That is Incorrect
        The Answer was {sum}
        ");
        Questions.Enqueue($"{rnd1} x {rnd2} = {Answer} X  Answer: {sum}");
            i++;
        }
    }
}

void DivisionGame(string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < 3;)
    {

        int rnd1, rnd2;
        RandomNumGen(out rnd1, out rnd2);

        int sum = rnd1 / rnd2;
        double remainder = rnd1 % rnd2;

        if (remainder == 0)
        {



            Console.WriteLine($"{rnd1} ÷ {rnd2}");
            int Answer = Convert.ToInt32(Console.ReadLine());


            if (Answer == sum)
            {
                Console.WriteLine("That Is Correct!");
                Questions.Enqueue($"{rnd1} ÷ {rnd2} = {Answer} {tick}");
            }
            else
            {
                Console.WriteLine(@$"Oops, That is Incorrect
                The Answer was {sum}
                ");
                Questions.Enqueue($"{rnd1} ÷ {rnd2} = {Answer} X  Answer: {sum}");
                i++;
            }
        }
    }
}
void AnsweredQuestion()
{   
    string title = "Previous Questions";
    Console.WriteLine(title);
    Console.WriteLine(new string ('‾',title.Length));
    foreach (var i in Questions)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Enter to return to menu");
    Console.ReadLine();

}

void MenuMethod()
{
    Console.WriteLine(@$"Please Enter An Operation
1 - Addition
2 - Subtraction
3 - Multiplication
4 - Division
5 - Answered Questions
0 - Quit
");

    int Selection = 20;
    bool isValidInput = false;


    // 1. Loop until a valid integer is entered
    while (!isValidInput)
    {
        string? input = Console.ReadLine();

        // 2. Validate the input using int.TryParse()
        if (int.TryParse(input, out Selection))
        {
            // The conversion was successful. We can now exit the loop.
            isValidInput = true;
        }
        else
        {
            // The conversion failed. Inform the user and loop again.
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }





    switch (Selection)
    {
        case 0:
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        case 1:
            AdditionGame("Addition Game Selected\nSolve This Question:\n");
            break;
        case 2:
            SubtractionGame("Subtraction Game Selected\nSolve This Question:\n");
            break;
        case 3:
            MultiplicationGame("Multiplication Game Selected\nSolve This Question:\n");
            break;
        case 4:
            DivisionGame("Division Game Selected\nSolve This Question:\n");
            break;
        case 5:
            AnsweredQuestion();
            break;
        default:
            Console.WriteLine("Incorrect Input\n");
            break;

    }
}

static void RandomNumGen(out int rnd1, out int rnd2)
{
    Random random = new Random();
    rnd1 = random.Next(0, 100);
    rnd2 = random.Next(0, 100);
}