// See https://aka.ms/new-console-template for more information
using Maths;

Console.WriteLine("Hello, World!");
Console.WriteLine("Testing C#");
Console.WriteLine("Another Line..!!");
Console.WriteLine("Hey there..!!");

var info = new {
    FirstName = "Palash",
    LastName = "Kardhekar"
};
int count = 12;
count++;
string course = "PG-DAC 2022";

Console.WriteLine("Personal Information : "+info.FirstName+" "+info.LastName);
Console.WriteLine("Counter : "+count);
Console.WriteLine("Course : "+course);

Complex c1 = new Complex(14, 25);
Complex c2 = new Complex(25, 79);
Complex c3 = c1 + c2;
Console.WriteLine("Result = "+c3.Real);
Console.WriteLine("Result = "+c3.Imag);

