using System.Threading.Tasks.Dataflow;

namespace Program
{
    public class Program
    {
        static List<int> fibonacciNumbers = [1, 1];

        

        static void fibonacciExample()
        {
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        static void fibonacciTwenty()
        {

            int counter = 1;
            do
            {
                int lastNum = fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(lastNum);
                counter++;

            } while (counter <= 20);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine($"{item}");
            }
        }
        public static void Main(string[] args)
        {

            fibonacciTwenty();

        }
    }
}
