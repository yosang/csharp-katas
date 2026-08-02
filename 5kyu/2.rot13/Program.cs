public class Kata
{
    public static string decodeROT13(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            // Alphabet has 26 letters in it, we must scan in the first half and the second half
            // If the letter appears in the first half, add 13 to it, otherwise substract 13
            char c = chars[i];

            if (c >= 'a' && c <= 'm' || c >= 'A' && c <= 'M')
            {
                chars[i] = (char)(c + 13);
                continue;
            }

            if (c >= 'n' && c <= 'z' || c >= 'N' && c <= 'Z')
            {
                chars[i] = (char)(c - 13);
            }
        }

        return new string(chars);
    }

    public static void Main()
    {
        var test = decodeROT13("EBG13 rknzcyr.");
        Console.WriteLine(test);

        var result = decodeROT13("Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.");
        Console.WriteLine(result);
    }
}