// See https://aka.ms/new-console-template for more information
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;

// order of operation is bidmas
// multiplication before addition
Console.WriteLine(d);
//4 x 2 = 8
//5 + 8 = 13

d = (a + b) * c;
Console.WriteLine(d);

// a + b first then multiply by c
// since brackets first
