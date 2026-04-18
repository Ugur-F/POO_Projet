namespace RefugePourAnimaux;

public class Adoptant
{
    private int _id;
    private string _nom;
    private string _prenom;
    private string _telephone;
    private string _email;

    public Adoptant(int id, string nom, string prenom, string telephone, string email)
    {
        _id = id;
        _nom = nom;
        _prenom = prenom;
        _telephone = telephone;
        _email = email;
    }

    public int Id => _id;
    public string Nom => _nom;
    public string Prenom => _prenom;
    public string Telephone => _telephone;
    public string Email => _email;

    public void AfficherInfos()
    {
        throw new NotImplementedException();
    }
}
