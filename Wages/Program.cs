//Variables

string name;
string hourlyPayAsString;
double hourlyPay;
double hourlyOvertimePay;

//Program
Console.WriteLine("Hello! Welcome to my program!");

Console.Write("What is your name? ");

name = Console.ReadLine();

Console.Write("What is your hourly pay? ");

//using Convert to change a string to a double
//hourlyPay = Convert.ToDouble(Console.ReadLine());

//using the data types Parse
hourlyPay = double.Parse(Console.ReadLine());


//my pseudo test area
Console.WriteLine($"Hello! {name}");

