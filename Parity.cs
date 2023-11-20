using System;
using System.Linq;

public class Parity
{
    public static string CheckParity(string bits)
    {
        int count = bits.Count(bit=> bit == '1');
        return count % 2 == 0 ? "EVEN" : "ODD";
    }

    public static int[] ConvertStringToBits(string bits)
    {
        return bits.Select(c => int.Parse(c.ToString())).ToArray();
    }

    public static int CalculateBCC(string bits)
    {
        int[] intBits = ConvertStringToBits(bits);
        int bcc = 0;
        foreach(var bit in intBits)
        {
            bcc += bit;
        }
        return bcc % 2;
    }

    public static bool CheckError(string bits, int bcc)
    {
        int calculatedBCC = CalculateBCC(bits);
        return calculatedBCC != bcc;
    }

    public static int FindBCCWithParity(string bits, string parityType)
    {
        int[] intBits = ConvertStringToBits(bits);
        int bcc = 0;
        foreach (var bit in intBits)
        {
            bcc += bit;
        }

        if (parityType.Equals("EVEN"))
        {
            int parity = CheckParity(bits) == "EVEN" ? 0 : 1;
            bcc += parity;
        }
        else if (parityType.Equals("ODD"))
        {
            int parity = CheckParity(bits) == "ODD" ? 0 : 1;
            bcc += parity;
        }

        return bcc % 2;
    }

    public static void Main(string[] args)
    {
        string bits = "1011011"; // Example input

        // Checking parity
        string parity = CheckParity(bits);
        Console.WriteLine($"Parity: {parity}");

        // Calculating BCC
        int bcc = CalculateBCC(bits);
        Console.WriteLine($"Calculated BCC: {bcc}");

        // Checking for error in BCC
        bool hasError = CheckError(bits, bcc);
        Console.WriteLine($"Has error: {hasError}");

        // Finding BCC with different parity
        int bccWithEvenParity = FindBCCWithParity(bits, "EVEN");
        Console.WriteLine($"BCC with EVEN parity: {bccWithEvenParity}");

        int bccWithOddParity = FindBCCWithParity(bits, "ODD");
        Console.WriteLine($"BCC with ODD parity: {bccWithOddParity}");
    }
}