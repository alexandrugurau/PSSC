namespace LAB1.Domain;

public record Person
{
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public string Telefon { get; set; }
    public string Adresa { get; set; }

    public override string ToString()
    {
        return $"Nume: {Nume}\n" +  //se returneaza sub aceasta forma datele despre persoana
               $"Prenume: {Prenume}\n" +
               $"Numar de telefon: {Telefon}\n" +
               $"Adresa: {Adresa}";
    }
}