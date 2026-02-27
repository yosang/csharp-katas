using System.Text;

namespace Kata;

public class Program
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split();

        for (int i = 0; i < words.Length; i++)
        {
            string w = words[i];

            if (w.Length >= 5)
            {
                words[i] = string.Concat(w.Reverse());
            }
        }

        return string.Join(" ", words);
    }
    public static void Main()
    {
        Console.WriteLine(SpinWords("Stop Spinning My Words"));
        Console.WriteLine(SpinWords("This is a test"));
        Console.WriteLine(SpinWords("This is another test"));
    }
}