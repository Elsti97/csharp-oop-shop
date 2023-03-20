using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Prodotto
{
    private int codiceBase;
    public int Codice { get { return codiceBase; } }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public double Iva { get; set; }

    public Prodotto(string nome, string descrizione, double prezzo, double iva)
    {
        codiceBase = GeneraCodice();
        Nome = nome;
        Descrizione = descrizione;
        Prezzo = prezzo;
        Iva = iva;
    }

    private int GeneraCodice()
    {
        Random random = new Random();
        return random.Next(1, 1000);
    }

    public double PrezzoBase()
    {
        return Prezzo;
    }

    public double PrezzoConIva()
    {
        return Prezzo * (1 + Iva / 100);
    }

    public string NomeEsteso()
    {
        return Codice + " + " + Nome;
    }
}
