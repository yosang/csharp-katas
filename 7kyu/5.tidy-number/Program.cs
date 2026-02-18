using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;

namespace Kata
{
    public class App
    {
        public static void Main()
        {

            // Console.WriteLine(Kata.TidyNumber(12)); // True
            // Console.WriteLine(Kata.TidyNumber(32)); // False
            // Console.WriteLine(Kata.TidyNumber(13579)); // True
            // Console.WriteLine(Kata.TidyNumber(1024)); // False

            Console.WriteLine(Kata.TidyNumberV2(12)); // True
            Console.WriteLine(Kata.TidyNumberV2(32)); // False
            Console.WriteLine(Kata.TidyNumberV2(13579)); // True
            Console.WriteLine(Kata.TidyNumberV2(1024)); // False
        }
    }

    public class Kata
    {
        // Sorting the digits and comparing with the original value
        public static bool TidyNumber(int n)
        {
            // We convert our int to string then to a char array in order to sort it
            char[] chars = n.ToString().ToCharArray();

            // Sort the array
            Array.Sort(chars);

            // Join the characters back to a string
            string joined = new String(chars);

            // Cast it back to an int with int.Parse
            int result = int.Parse(joined);

            // Do the boolean comparison to see if its tidy
            bool isTidy = result == n;

            return isTidy;
        }

        // Comparing numbers with a loop
        public static bool TidyNumberV2(int n)
        {
            // Convert the int to a string so we can iterate it
            string s = n.ToString();

            // Iterate every character of the string
            for (int i = 0; i < s.Length - 1; i++)
            {
                // Console.WriteLine(s[i].GetType().Name); // We are working with characters here

                if (s[i] > s[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}