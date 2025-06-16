//tuples = ordered sequence of values with fixed length
//each element has a type and optional name
var pt = (X: 1, Y: 2);

//pt calls the variable and .Y calls the value named Y which is 2
//same for .X 
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origim to the point {pt} has a slope of {slope}");

//tuples can be reassigned
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

//New, modified copy of tuple pt or tuple pt V2

var pt2 = pt with { Y = 10 };
//tuple pt2 contains pt.X after it was reassigned above
// and it contains Y = 10 from ln 16
//its basically saying take pt and set it as pt2 but instead of Y from pt
//use Y = 10 instead
Console.WriteLine($"The point 'pt2' is at {pt2}");

//tuple type is defined by no. members aka arity
//aswell as the types of its members

// member names are purely for convenience

var subscript = (A: 0, B: 0);
subscript = pt;
//pt can be assigned to subscript since the tuple size and member types are the same
//regardless of the member names
Console.WriteLine(subscript);

//Tuples are easy to create but limited in capabilities
//cant convey meaning of set of values or add behaviour