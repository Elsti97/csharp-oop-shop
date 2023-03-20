// Codifica caratteri speciali, per mostrare a schermo simbolo dell'euro in questo caso
Console.OutputEncoding = System.Text.Encoding.UTF8;

Prodotto p1 = new Prodotto("Felpa", "Felpa con cappuccio nera", 100, 22);
Console.WriteLine("Codice: " + p1.CodicePadLeft());
Console.WriteLine("Nome prodotto: " + p1.Nome);
Console.WriteLine("Descrizione prodotto: " + p1.Descrizione);
Console.WriteLine("Prezzo esentasse: " + p1.Prezzo + "\u20AC");
Console.WriteLine("Prezzo con IVA: " + p1.PrezzoConIva() + "\u20AC");
Console.WriteLine("Codice e nome: " + p1.NomeEsteso());
Console.WriteLine();



// Array Bonus
Prodotto[] prodotti = new Prodotto[3];
{
    prodotti[0] = new Prodotto ("Felpa", "Felpa con cappuccio nera", 100, 22);
    prodotti[1] = new Prodotto ("Maglietta", "Maglietta bianca", 50, 22);
    prodotti[2] = new Prodotto ("Jeans", "Jeans blu scuro", 80, 22);
}

foreach (Prodotto prodotto in prodotti)
{
    Console.WriteLine("Codice: " + prodotto.CodicePadLeft());
    Console.WriteLine("Nome prodotto: " + prodotto.Nome);
    Console.WriteLine("Descrizione prodotto: " + prodotto.Descrizione);
    Console.WriteLine("Prezzo esentasse: " + prodotto.Prezzo + "\u20AC");
    Console.WriteLine("Prezzo con IVA: " + prodotto.PrezzoConIva() + "\u20AC");
    Console.WriteLine("Codice e nome: " + prodotto.NomeEsteso());
}


