using System.Text;
using System.Linq;
using static System.Console;

// WriteLine(reversedString("hello"));
// WriteLine(reversedString("word"));

// WriteLine(reversedStringLoop("hello"));
// WriteLine(reversedStringLoopSB("hello"));
WriteLine(reversedStringLINQ("hello"));

string reversedString(string s)
{
    // In order to reverse an array we need to deal with individual chars.

    // Convert the string to an array of chars.
    char[] myArr = s.ToCharArray();

    // Reverse the array using System.Array
    Array.Reverse(myArr);

    return new string(myArr); // Returns a string, new string takes an array of unicode characters.
}

// Concatenation is innefficient, because strings are immutable
string reversedStringLoop(string s)
{
    string result = ""; // creates a new string copy for every concatenation, old strings will eventually be gargbage collected

    for (int i = s.Length - 1; i >= 0; i--)
    {
        result += s[i];
    }
    return result;
}

string reversedStringLoopSB(string s)
{
    StringBuilder result = new StringBuilder(); // StringBuilders are mutable

    for (int i = s.Length - 1; i >= 0; i--)
    {
        result.Append(s[i]);
    }
    return result.ToString(); // We convert our SB to a string;
}

// Probably the easiest way
string reversedStringLINQ(string s)
{
    char[] reversed = s.Reverse().ToArray(); // Reverse return an IEnumerable<char> object, ToArray takes IEnumerable

    return string.Concat(reversed);

    // we can also do
    // return string.Concat(s.Reverse());
}