// See https://aka.ms/new-console-template for more information
namespace Program
{
    public class Program
    {

        static int a = 5;
        static int b = 3;
        static int c = 4;


        static void IfStatmentExample()
        {
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }

        static void IfStatmentExampleV2()
        {
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");  
            }
        }

        static void ifStatementOr()
        {
             if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is either greater than 10 or a and b are the same");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("A and b are not the same");  
            }
        }

        public static void Main()
        {
            //IfStatmentExample();
            //IfStatmentExampleV2();
            ifStatementOr();
        }
    }
}