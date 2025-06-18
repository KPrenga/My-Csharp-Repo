namespace Program
{
    public class Program
    {
        static int counter = 0;
        static void whileLoop()
        {
            while (counter <= 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
                //++ is increment operator
            }
        }

        static void doWhileLoop()
        {
            //do excecutes first then checks the while condition
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter <= 10);
        }

        static void forLoop()
        {
            //first is initialiser: int count = 0 declares count as loop variable
            //middle is the condition
            //final is the iterator/ how to modify the variable
            for (int count = 0; count <= 10; count++)
            {
                Console.WriteLine($"Hello World! The count is {count}");
            }
        }

        static void nestedLoops()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        static void threeFactorFor()
        {
            Console.WriteLine("Numbers divisible by 3:");
            for (int counterFor = 1; counterFor <= 20; counterFor++)
            {
                if (counterFor % 3 == 0)
                {
                    Console.WriteLine(counterFor);
                }
            }
        }

        static void threeFactorWhile()
        {
            int counterWhile = 1;
            Console.WriteLine("Numbers divisible by 3:");
            do
            {
                if (counterWhile % 3 == 0)
                {
                    Console.WriteLine(counterWhile);
                }
                counterWhile++;
            } while (counterWhile <= 20);

            
        }


        public static void Main(string[] args)
        {
            //whileLoop();
            //doWhileLoop();
            //forLoop();
            //nestedLoops();
            //threeFactorFor();
            //threeFactorWhile();
        }
    }
}
