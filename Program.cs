Prodotto p1 = new Prodotto("Felpa", "Felpa con cappuccio nera", 100, 22);
Console.WriteLine("Codice: " + p1.CodicePadLeft());
Console.WriteLine("Nome prodotto: " + p1.Nome);
Console.WriteLine("Descrizione prodotto: " + p1.Descrizione);
Console.WriteLine("Prezzo esentasse: " + p1.PrezzoBase());
Console.WriteLine("Prezzo con IVA: " + p1.PrezzoConIva());
Console.WriteLine("Codice e nome: " + p1.NomeEsteso());

