public class Kata
{
    // An octet is simply a value that consists of exactly 8 bits
    // In c# this value has a type and that is byte
    // To check if a number is an octet, we need to verify its ranges for a byte, which is 0 - 255

    public static bool isAnOctet(int n)
    {
        if (n < 0 || n > 255 || n != (byte)n) return false; // If the num is below 0, or above 255, or not of a byte type, return false

        return true;
    }

    public static bool IsValidIp(string ipAddres)
    {
        string[] arrOfOctets = ipAddres.Split(".");

        if (arrOfOctets.Length != 4) return false;

        foreach (string octet in arrOfOctets)
        {
            // If the octet is not 0, and starts with 0 
            // or has leading/trailing space characters
            // or starts with a -, return false
            if (octet != "0" && octet.StartsWith("0") || octet.StartsWith("-") || octet.StartsWith(" ") || octet.EndsWith(" "))
                return false;

            // If we cant parse the string format to an int variable, return false
            if (!int.TryParse(octet, out int number))
                return false;

            Console.WriteLine(number);

            // If its not an octet, return false
            if (!isAnOctet(number))
                return false;
        }

        return true;
    }
    public static void Main()
    {
        // Truthful scenarios
        // Console.WriteLine(IsValidIp("1.2.3.4")); // Valid, all 4 digits are octets
        // Console.WriteLine(IsValidIp("123.45.67.89")); // Valid, all 4 digits are octets
        // Console.WriteLine(IsValidIp("0.0.0.0")); // Valid, 0's are octets

        // Erroneous scenarios
        // Console.WriteLine(IsValidIp("abc")); // Wrong format (not numeric)
        // Console.WriteLine(IsValidIp("abc.def.ghi.jkl")); // Wrong format (not numeric)
        // Console.WriteLine(IsValidIp("123.456.789.0")); // Not all numbers are octets (456 and 789 are > 255)
        // Console.WriteLine(IsValidIp("12.34.56 .1")); // Wrong format (trailing space in 56 )
        // Console.WriteLine(IsValidIp("1.2.3")); // Does not consist of 4 octets (only 3 here)
        // Console.WriteLine(IsValidIp("1.2.3.4.5")); // Too many octets (5 here)
        // Console.WriteLine(IsValidIp("123.456.78.90")); // One of the numbers is not an octet (456)
        // Console.WriteLine(IsValidIp("123.045.067.089")); // Numbers have leading zeros
        // Console.WriteLine(IsValidIp("170.133.-0.245")); // Has a negative digit

        // * Testing the octet function
        // Console.WriteLine(isAnOctet(05)); // True
        // Console.WriteLine(isAnOctet(5)); // True
        // // Console.WriteLine(isAnOctet(300)); // False
        // Console.WriteLine(isAnOctet(-1)); // False
    }
}