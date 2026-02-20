using System.Collections.Generic;
using System.Text;

namespace BackspaceStringProcessor
{
    public class App
    {
        public class TextCannotBeEmptyException : Exception
        {
            public TextCannotBeEmptyException(string message) : base(message) { }
        }

        /// <summary>
        /// Stack method - using System.Collections.Generic
        /// Processes a string where '#' acts as a backspace character
        /// Uses expliciti Stack<char> approach.
        /// </summary>
        public static string ProcessBackspaces(string text, char symbol = '#')
        {
            // No point in processing an empty string, so just throw an exception if its empty before moving on
            if (text.Length < 1) throw new TextCannotBeEmptyException("Input text cannot be empty");

            Stack<char> myStack = new Stack<char>(); // We are using a stack for the backspacing = everytime we encounter a symbol, we pop from the stack, otherwise push

            // Iterate each character of the text string, if its not a #, push it to our stack
            // Otherwise check if we have items in our stack, and remove pop them each time we encounter a #
            foreach (char c in text)
            {
                if (c != symbol)
                {
                    myStack.Push(c);
                }
                else if (myStack.Count > 0) // Make sure we pop only if there are items in the stack
                {
                    myStack.Pop();
                }
            }

            // We can reverse a stack by creating a new stack from the original stack
            Stack<char> reversed = new Stack<char>(myStack);

            // We can also use the stack.Reverse, and convert it to an array
            char[] reversedArr = myStack.Reverse().ToArray();

            // We can join the arr back with string.Join
            // But when array only contains chars, we can just use new string
            string result = new string(reversedArr);

            return result;
        }

        /// <summary>
        /// StringBuilder method - Using System.Text
        /// 
        /// </summary>
        public static string ProcessBackspacesSB(string text, char symbol = '#')
        {
            if (text.Length < 1) throw new TextCannotBeEmptyException("Input text cannot be empty");

            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (c != symbol)
                {
                    sb.Append(c);
                }
                else
                {
                    if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
                }
            }

            return sb.ToString();
        }

        public static void Main()
        {
            string s1 = "abc#d##c";
            string s2 = "abc##d######";
            string s3 = "#######";
            // string s4 = "";

            // Solution with a Stack:
            Console.WriteLine(ProcessBackspaces(s1));
            // Console.WriteLine(ProcessBackspaces(s2)); // should return and empty string
            // Console.WriteLine(ProcessBackspaces(s3));
            // Console.WriteLine(ProcessBackspaces(s4)); // throws an exception

            // Solution with a StringBuilder
            // Console.WriteLine(ProcessBackspacesSB(s1));
            // Console.WriteLine(ProcessBackspacesSB(s2));
            // Console.WriteLine(ProcessBackspacesSB(s3));
            // Console.WriteLine(ProcessBackspacesSB(s4));
        }
    }
}