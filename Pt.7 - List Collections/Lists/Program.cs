using System.Net.Security;

namespace Program
{
    public class Program
    {

        static string dividerLine = "<------------------------------>";
        public static void Main(string[] args)
        {
            // creates [list of strings] Called names = [Contents]
            List<string> names = ["Mark", "Ana", "Felipe"];
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //list editing
            Console.WriteLine();
            Console.WriteLine(dividerLine);
            Console.WriteLine();

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            Console.WriteLine(dividerLine);
            Console.WriteLine();

            //individual referencing
            Console.WriteLine($"first name: {names[0]}");
            Console.WriteLine($"Added names: {names[2]}, {names[3]}");
            //list size counting
            Console.WriteLine($"list lenght: {names.Count}");


            Console.WriteLine();
            Console.WriteLine(dividerLine);
            Console.WriteLine();

            //search and sort lists

            //searching
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            Console.WriteLine();

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            Console.WriteLine();
            Console.WriteLine(dividerLine);
            Console.WriteLine();

            //sorting

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            Console.WriteLine(dividerLine);
            Console.WriteLine();

        }
    }
}