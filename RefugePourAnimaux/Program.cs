namespace RefugePourAnimaux;

internal class Program
{
    private static void Main(string[] args)
    {
        Enclos enclos = new Enclos(1, "Enclos principal", 10, "Chiens et chats");
        DossierMedical dossier = new DossierMedical(1, DateTime.Today, "Aucun", "Aucun", "Dossier créé.");

        Chien chien = new Chien(1, "Rosko", 4, "Mâle", DateTime.Today, enclos, dossier, "Labrador", "Grand", true);
        Chat chat = new Chat(2, "Melosh", 2, "Femelle", DateTime.Today, enclos, dossier, "Blanc", true, 4.2);
        Adoptant adoptant = new Adoptant(1, "Dupont", "Marie", "0600000000", "marie.dupont@email.com");
        Employe employe = new Employe(1, "Martin", "Paul", "Soigneur", DateTime.Today, dossier);
        Adoption adoption = new Adoption(1, DateTime.Today, "En cours", 120.0, chien, adoptant);

        Console.WriteLine("Squelette opérationnel.");
        Console.WriteLine($"Animal créé : {chien.Nom}");
        Console.WriteLine($"Animal créé : {chat.Nom}");
        Console.WriteLine($"Adoptant créé : {adoptant.Prenom} {adoptant.Nom}");
        Console.WriteLine($"Employé créé : {employe.Prenom} {employe.Nom}");
        Console.WriteLine($"Adoption créée : dossier #{adoption.Id}");
    }
}
