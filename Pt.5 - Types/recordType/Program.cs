// See https://aka.ms/new-console-template for more information
namespace Program
{
    public class Program
    {

        //record stores values for point in read-only
        public record struct Point(int X, int Y)
        //named types show how the type is used
        // struct (added afterwards) adds behaviour to the record
        {
            //slope is a member that is used to calculate the slope of any tuple
            //with the point structure like pt
            public double Slope() => (double)Y / (double)X;


        }

        public static void Main()
        {
            //using point gives pt its structure as a data type
            //its like point pt now has to consist of 2 members that are integers
            //so (1,1) becomes integer X = 1 and integer Y = 1
            //or pt = (X: 1, Y: 1)
            Point pt = new Point(1, 1);
            var pt2 = pt with { Y = 10 };
            double Slope = pt.Slope();
            Console.WriteLine($"The slope of {pt} is {Slope}");

        }
    }
}


//struct is value type (storing values)
//class is reference type (object oriented)