using System;
using System.Collections;

class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Courriel { get; set; }
    public string CarteCredit { get; set; }
    public int NumeroChambre { get; set; }

    public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
    {
        Nom = nom;
        Prenom = prenom;
        Courriel = courriel;
        CarteCredit = carteCredit;
        NumeroChambre = numeroChambre;
    }
}

class Hotel
{
    public ArrayList Clients { get; set; }

    public Hotel()
    {
        Clients = new ArrayList();
    }

    public void AjouterClient(Client client)
    {
        Clients.Add(client);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        Client client1 = new Client("Dupont", "Jean", "jean.dupont@mail.com", "1234567890123456", 101);
        Client client2 = new Client("Martin", "Sophie", "sophie.martin@mail.com", "2345678901234567", 102);

        hotel.AjouterClient(client1);
        hotel.AjouterClient(client2);

        Console.WriteLine("Liste des clients de l'hôtel :");

        foreach (Client client in hotel.Clients)
        {
            Console.WriteLine(client.Nom + " " + client.Prenom + " - Chambre " + client.NumeroChambre);
        }

        Console.ReadLine();
    }
}