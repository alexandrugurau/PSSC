using LAB1.Domain;
using static LAB1.Domain.Quantity; //pt. utilizarea tipurilor si metodelor


internal class Program
{
    private static Person person = new Person() //variabila de tip Person
    {
        Nume = "Alex",
        Prenume = "Gurau",
        Telefon = "0757963058",
        Adresa = "Ciucago"
    };
    private static List<Product> products = new List<Product>(); //variabila de tip List<Product>
    private static Command command = new Command(); //variabila de tip Command
    private static byte option = 0; //variabila de tip byte pt. optiuni

    private static void Main(string[] args)
    {
        Console.WriteLine("1. Creati o comanda");
        Console.WriteLine("2. Iesire\n");

        Console.Write("Introducere optiune: ");
        option = Convert.ToByte(Console.ReadLine()); //varibila primeste o optiune

        Console.Clear(); //se sterge continutul consolei pentru a elibera ecranul

        if (option == 1)
        {
            do //creearea comenzii
            {
                Console.WriteLine("1. Adaugare produs");
                Console.WriteLine("2. Vizualizare comanda");
                Console.WriteLine("3. Finalizare comanda");

                Console.Write("\nIntroduceti optiunea: ");
                option = Convert.ToByte(Console.ReadLine());

                Console.Clear();

                if (option == 1) //adaugarea unui produs
                {
                    Console.Write("Cod produs: "); //scriem un cod de produs
                    string? code = Console.ReadLine(); //? inseamna ca acea variabila poate fi null

                    Console.Write("Cantitate: "); //scriem cantitatea produsului
                    string quantity = Console.ReadLine();

                    products.Add(new Product() //se creeaza o noua instanta a clsei Product ce este adaugata in lista
                    {
                        Cod = code,
                        Quantity = ConvertToQuantity(quantity)
                    });

                    Console.Clear();
                }
                else if (option == 2) //vizualizarea unei comenzi
                {
                    if (products.Count == 0) //se verifica daca comanda este goala
                    {
                        Console.WriteLine("Nu a fost introdus niciun produs");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else foreach (Product p in products) //se afiseaza detalii despre produsele introduse in comanda
                            Console.WriteLine(p.ToString());

                    Console.ReadLine();
                    Console.Clear();
                }
            } while (option != 3); //produsele pot fi adaugate sau afisate pana la introducerea comenzii 3, ce se refera la finalizarea comenzii

            products.RemoveAll(p => p.Quantity.GetType().Name.Equals("Undefined")); //sunt eliminate produsele cu cantitare nedefinita
            command = new Command() //se creeaza o noua comanda
            {
                Person = person, //initializarea proprietatilor obiectului nou creat
                ProductsList = products
            };
        }

        Console.WriteLine("1. Vizualizare comanda"); 
        Console.WriteLine("2. Iesire");

        Console.Write("\nIntroduceti optiunea: ");
        option = Convert.ToByte(Console.ReadLine());

        Console.Clear();

        if (option == 1)
        {
            Console.WriteLine(command.ToString());
            Console.ReadLine();
            Console.Clear();
        }
    }
}