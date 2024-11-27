Console.WriteLine("Här kan du skapa din shoppinglista");
Console.WriteLine("Skriv 'klar' när du är klar");

List<string> products = [];
while (true)
{
    Console.WriteLine("Ange din produkt:");
    string product = Console.ReadLine()!;
    if (product == "klar")
    {
        break;
    }
    products.Add(product);
    Console.WriteLine(product, " tilllagd");
}

Console.WriteLine("Här är din lista:");

foreach (string product in products)
{
    Console.WriteLine(product);
}

Console.ReadKey();
