namespace RefugePourAnimaux;

public class Enclos
{
    private int _id;
    private string _nom;
    private int _capacite;
    private string _typeEnclos;

    public Enclos(int id, string nom, int capacite, string typeEnclos)
    {
        _id = id;
        _nom = nom;
        _capacite = capacite;
        _typeEnclos = typeEnclos;
    }

    public int Id => _id;
    public string Nom => _nom;
    public int Capacite => _capacite;
    public string TypeEnclos => _typeEnclos;

    public void AjouterAnimal()
    {
        throw new NotImplementedException();
    }

    public void RetirerAnimal()
    {
        throw new NotImplementedException();
    }

    public void AfficherCapacite()
    {
        throw new NotImplementedException();
    }
}
