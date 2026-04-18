namespace RefugePourAnimaux;

public class Employe
{
    private int _id;
    private string _nom;
    private string _prenom;
    private string _fonction;
    private DateTime _dateEmbauche;
    private DossierMedical _dossierMedical;

    public Employe(int id, string nom, string prenom, string fonction, DateTime dateEmbauche, DossierMedical dossierMedical)
    {
        _id = id;
        _nom = nom;
        _prenom = prenom;
        _fonction = fonction;
        _dateEmbauche = dateEmbauche;
        _dossierMedical = dossierMedical;
    }

    public int Id => _id;
    public string Nom => _nom;
    public string Prenom => _prenom;
    public string Fonction => _fonction;
    public DateTime DateEmbauche => _dateEmbauche;
    public DossierMedical DossierMedical => _dossierMedical;

    public void AfficherInfos()
    {
        throw new NotImplementedException();
    }

    public void NourrirAnimal()
    {
        throw new NotImplementedException();
    }

    public void NettoyerEnclos()
    {
        throw new NotImplementedException();
    }
}
