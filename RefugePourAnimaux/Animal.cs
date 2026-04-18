namespace RefugePourAnimaux;

public abstract class Animal
{
    private int _id;
    private string _nom;
    private int _age;
    private string _sexe;
    private DateTime _dateArrivee;
    private Enclos _enclos;
    private DossierMedical _dossierMedical;

    protected Animal(int id, string nom, int age, string sexe, DateTime dateArrivee, Enclos enclos, DossierMedical dossierMedical)
    {
        _id = id;
        _nom = nom;
        _age = age;
        _sexe = sexe;
        _dateArrivee = dateArrivee;
        _enclos = enclos;
        _dossierMedical = dossierMedical;
    }

    public int Id => _id;
    public string Nom => _nom;
    public int Age => _age;
    public string Sexe => _sexe;
    public DateTime DateArrivee => _dateArrivee;
    public Enclos Enclos => _enclos;
    public DossierMedical DossierMedical => _dossierMedical;

    public abstract void AfficherInfos();
}
