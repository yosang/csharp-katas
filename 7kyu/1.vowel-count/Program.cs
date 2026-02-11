using System;
using System.Linq;
public static class Kata
{
    static void Main()
    {
        Console.WriteLine(GetVowelCount("abracadabra"));
        Console.WriteLine(GetVowelCountIndex("abracadabra"));
        Console.WriteLine(GetVowelCountLINQ("abracadabra"));
    }
    public static int GetVowelCount(string str)
    {
        string vowels = "aeiou";

        int vowelCount = 0;

        foreach (char c in str)
        {
            if (vowels.Contains(c)) vowelCount++; // The string Contains method uses a char type by default
        }

        return vowelCount;
    }

    public static int GetVowelCountIndex(string str)
    {
        string vowels = "aeiou";
        int vowelCount = 0;

        foreach (char c in str)
        {
            int index = vowels.IndexOf(c);
            if (vowels.IndexOf(c) >= 0) vowelCount++; // indexOf also takes a char
        }

        return vowelCount;
    }
    public static int GetVowelCountLINQ(string str) // takes a string, returns an int
    {
        int vowelCount = 0; // increment the count if the char is in the array
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; // array of vowels, typed char with single quotes

        foreach (char c in str) // loop the string as we would with a normal array
        {
            if (vowels.Contains(c)) vowelCount++; // c is type char which matches with our array items
        }

        return vowelCount;
    }
}
