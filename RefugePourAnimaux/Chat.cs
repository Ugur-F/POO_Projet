namespace RefugePourAnimaux;

public class Chat : Animal
{
    private string _couleur;
    private bool _estSterilise;
    private double _poids;

    public Chat(
        int id,
        string nom,
        int age,
        string sexe,
        DateTime dateArrivee,
        Enclos enclos,
        DossierMedical dossierMedical,
        string couleur,
        bool estSterilise,
        double poids)
        : base(id, nom, age, sexe, dateArrivee, enclos, dossierMedical)
    {
        _couleur = couleur;
        _estSterilise = estSterilise;
        _poids = poids;
    }

    public string Couleur => _couleur;
    public bool EstSterilise => _estSterilise;
    public double Poids => _poids;

    public override void AfficherInfos()
    {
        throw new NotImplementedException();
    }
}
