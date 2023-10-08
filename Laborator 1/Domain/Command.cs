using System.Text;

namespace LAB1.Domain;

public record Command
{
    public Person Person { get; set; } //se permite accesul la obiecte de tip Person asociate
    public List<Product> ProductsList { get; set; } //se permite accesul la o lista de obiecte de tip Person

    public override string ToString()
    {
        StringBuilder tmp = new StringBuilder(Person.ToString() + "\n\nComanda:"); //se creeeaza o instanta a clasei StringBuilder pentru a creea siruri de caractere eficient
                                                                                   //va contrui pentru persoana si comanda
        foreach (Product p in ProductsList)
            tmp.Append("\n" + p.ToString()); //se adauga detalii despre produs

        return tmp.ToString();
    }
}
