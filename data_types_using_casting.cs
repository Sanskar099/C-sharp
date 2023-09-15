int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
decimal MyDecimal = 1.23456789m;
float myFloat = (float)MyDecimal;
Console.WriteLine(myFloat);
Console.WriteLine(MyDecimal);
// decimal are more precise

// int first = 1;
// int second = 2;
// string s = first.ToString() + second.ToString();
// Console.WriteLine(s);

string first = "1";
string second = "2";
int num = int.Parse(first) + int.Parse(second);
Console.WriteLine($"this is the num: {num}");

string value1 = "1";
string value2 = "2";
int n1 = Convert.ToInt32(value1) + Convert.ToInt32(value2);
Console.WriteLine(n1);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value); // this rounds up to the smaller number

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3); // this rounds up to the larger number

// That’s correct. Convert.ToInt32() rounds values with fractional precision
// Correct. decimal to int is a narrowing conversion so cast is the best answer.

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal tot = 0m;
string message = "";
foreach(var value in values){
    decimal number;
    if(decimal.TryParse(value,  out number)){
        tot += number;
    }
    else{
        message += value;
    }
}
Console.WriteLine(tot);
Console.WriteLine(message);

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
