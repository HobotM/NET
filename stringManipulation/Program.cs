int a = 100;
float b = 250.0f;
string c = "CSharp";

// Interpolation
System.Console.WriteLine("The values are {0}, {1}, {2}", a, b, c);
System.Console.WriteLine($"The values are {a}, {b}, {c}");

// Interpolation expression in strings

System.Console.WriteLine($"(a + b)/b is {(a + b) / b}");
System.Console.WriteLine($"{c} in upper case is {c.ToUpper()}"); // to upper

// objects can be embedded as in strings

DateTime now = DateTime.Now;
System.Console.WriteLine($"Today is {now}");

string myString = "  Hello, World!  ";

// Length of string
int length = myString.Length;
Console.WriteLine($"Length: {length}");

// Substring
string substring1 = myString.Substring(0, 5); // "Hello"
string substring2 = myString.Substring(7); // "World!"
Console.WriteLine($"Substring 1: {substring1}");
Console.WriteLine($"Substring 2: {substring2}");

// Concatenation
string str1 = "Hello";
string str2 = "World";
string concat = String.Concat(str1, " ", str2); // "Hello World"
Console.WriteLine($"Concatenation: {concat}");

// Replace
string replaced = myString.Replace("World", "Universe"); // "Hello, Universe!"
Console.WriteLine($"Replace: {replaced}");

// Split
string[] split = myString.Split(','); // { "Hello", " World!  " }
Console.WriteLine($"Split: {String.Join(",", split)}");

// Trim
string whitespace = "   whitespace   ";
string trimmed = whitespace.Trim(); // "whitespace"
Console.WriteLine($"Trimmed: {trimmed}");

// Convert to uppercase/lowercase
string upper = myString.ToUpper(); // "  HELLO, WORLD!  "
string lower = myString.ToLower(); // "  hello, world!  "
Console.WriteLine($"Uppercase: {upper}");
Console.WriteLine($"Lowercase: {lower}");

// Check if string contains substring
bool contains = myString.Contains("World"); // true
Console.WriteLine($"Contains 'World': {contains}");

// Index of substring
int index = myString.IndexOf("World"); // 7
Console.WriteLine($"Index of 'World': {index}");

// Pad left/right
string leftPad = myString.PadLeft(20); // "     Hello, World!  "
string rightPad = myString.PadRight(20); // "  Hello, World!     "
Console.WriteLine($"Left Pad: {leftPad}");
Console.WriteLine($"Right Pad: {rightPad}");

// Remove
string removed = myString.Remove(0, 2); // "Hello, World!  "
Console.WriteLine($"Removed: {removed}");

// Insert
string inserted = myString.Insert(0, "Greetings! "); // "Greetings!   Hello, World!  "
Console.WriteLine($"Inserted: {inserted}");

// Join
string[] words = { "The", "quick", "brown", "fox" };
string joined = String.Join(" ", words); // "The quick brown fox"
Console.WriteLine($"Joined: {joined}");

// Format
string formatted = String.Format("Hello, {0}!", "World"); // "Hello, World!"
Console.WriteLine($"Formatted: {formatted}");

// Compare
int compare = String.Compare("abc", "def"); // -1
Console.WriteLine($"Compare: {compare}");

// StartsWith/EndsWith
bool startsWith = myString.StartsWith("Hello"); // true
bool endsWith = myString.EndsWith("!"); // true
Console.WriteLine($"Starts with 'Hello': {startsWith}");
Console.WriteLine($"Ends with '!': {endsWith}");


string name = "John";
int age = 30;

// Basic string interpolation
string message1 = $"My name is {name} and I am {age} years old.";
Console.WriteLine(message1); // "My name is John and I am 30 years old."

// Format specifiers
double number = 1234.5678;
string message2 = $"The number is {number:F2}"; // "The number is 1234.57"
Console.WriteLine(message2);

// Alignment and padding
int number1 = 123;
int number2 = 4567;
string message3 = $"Number 1: {number1,-10} Number 2: {number2,10}";
Console.WriteLine(message3); // "Number 1: 123        Number 2:       4567"

// Calling methods and properties
DateTime today = DateTime.Now;
string message4 = $"Today is {today:D}"; // "Today is Thursday, April 29, 2023"
Console.WriteLine(message4);

// Interpolating objects
MyClass myObject = new MyClass();
string message5 = $"My object: {myObject}";
Console.WriteLine(message5); // "My object: MyClass"

// Interpolating expressions
int x = 10;
int y = 20;
string message6 = $"The sum of {x} and {y} is {x + y}";
Console.WriteLine(message6); // "The sum of 10 and 20 is 30"


class MyClass
{
    public override string ToString()
    {
        return "MyClass";
    }
}