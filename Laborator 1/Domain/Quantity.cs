using CSharp.Choices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LAB1.Domain;

[AsChoice]
public static partial class Quantity 
{
    public interface IQuantity { }

    public record Units(int number) : IQuantity //se defineste un tip de date de tip units
    {
        public override string ToString() => $"{number}u";
    }

    public record Kilograms(double number) : IQuantity //se defineste un tip de date de tip kg
    {
        public override string ToString() => $"{number}kg";
    }

    public record Undefined(string value) : IQuantity //se defineste un tip de date nedefinit
    {
        public override string ToString() => $"{value} is undefined";
    }

    public static IQuantity ConvertToQuantity(string quantity) //convertirea lui qunatitt intr-un tip de date
    {
        if (int.TryParse(quantity, out var units))
            return new Units(units);
        else if (double.TryParse(quantity, out var kilograms))
            return new Kilograms(kilograms);
        else return new Undefined(quantity);
    }
}