// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        DigitalsizeBits bits = new DigitalsizeBits(9000000);

        Console.WriteLine($"{bits.Bit}");
        Console.WriteLine($"{bits.Byte}");
        Console.WriteLine($"{bits.Kbyte}");
        Console.WriteLine($"{bits.Mbyte}");
    }
}

struct DigitalsizeBits
{
    private long bit;

    public DigitalsizeBits(long initailSize)
    {
        this.bit = initailSize;
    }

    // Constants for conversions
    private const long BITSnBITS = 1;  // convert bits to bits
    private const long BITSnBYTES = 8;  // convert bytes to bits ( 1 byte = 8 bits)
    private const long BITSnKBYTES = 1024*8;  // Kbyte to bits
    private const long BITSnMBYTES = 1024*1024*8; // Mbyte to bits

    // Property to convrt the size into bits and return it
    public string Bit => $"{bit} bit = {bit} bits";
    public string Byte => $"{bit} bits = {bit/BITSnBYTES} Bytes";
    public string Kbyte => $"{bit} bits = {(bit/BITSnKBYTES)} KB";
    public string Mbyte => $"{bit} bits = {(bit/BITSnMBYTES)} MB";
}
