using Metigator.NumberSystem;
using Metigator.NumberSystem.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var d = new DecimalSystem("10");
       var binary = d.To(NumberBase.BINARY);
        var octal  = d.To(NumberBase.OCTAL);
        var hexadecimal = d.To(NumberBase.HEXADECIMAL);
        Console.WriteLine($"({d.Value })10= ({binary}){(int)NumberBase.BINARY}");
        Console.WriteLine($"({d.Value})10= ({octal}){(int)NumberBase.OCTAL}");
        Console.WriteLine($"({d.Value})10= ({hexadecimal}){(int)NumberBase.HEXADECIMAL}");
        Console.ReadKey();
    }
}