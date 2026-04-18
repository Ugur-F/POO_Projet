namespace RefugePourAnimaux;

public class Chien : Animal
{
    private string _race;
    private string _taille;
    private bool _estDresse;

    public Chien(
        int id,
        string nom,
        int age,
        string sexe,
        DateTime dateArrivee,
        Enclos enclos,
        DossierMedical dossierMedical,
        string race,
        string taille,
        bool estDresse)
        : base(id, nom, age, sexe, dateArrivee, enclos, dossierMedical)
    {
        _race = race;
        _taille = taille;
        _estDresse = estDresse;
    }

    public string Race => _race;
    public string Taille => _taille;
    public bool EstDresse => _estDresse;

    public override void AfficherInfos()
    {
        throw new NotImplementedException();
    }
}
