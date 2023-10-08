using static LAB1.Domain.Quantity;

namespace LAB1.Domain;

public record Product
{
    public string Cod { get; set; } //se definesc codul si cantitatea
    public IQuantity Quantity { get; init; }

    public override string ToString()
    {
        return "Cod produs: " + Cod + ", Cantitate: " + //se returneaza produsul si cantitatea
            Quantity.Match(whenUnits: units => units,
                           whenKilograms: kilograms => kilograms,
                           whenUndefined: undefined => undefined).ToString();
    }
}