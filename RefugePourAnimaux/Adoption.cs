namespace RefugePourAnimaux;

public class Adoption
{
    private int _id;
    private DateTime _dateAdoption;
    private string _statutDossier;
    private double _fraisAdoption;
    private Animal _animal;
    private Adoptant _adoptant;

    public Adoption(int id, DateTime dateAdoption, string statutDossier, double fraisAdoption, Animal animal, Adoptant adoptant)
    {
        _id = id;
        _dateAdoption = dateAdoption;
        _statutDossier = statutDossier;
        _fraisAdoption = fraisAdoption;
        _animal = animal;
        _adoptant = adoptant;
    }

    public int Id => _id;
    public DateTime DateAdoption => _dateAdoption;
    public string StatutDossier => _statutDossier;
    public double FraisAdoption => _fraisAdoption;
    public Animal Animal => _animal;
    public Adoptant Adoptant => _adoptant;

    public void Valider()
    {
        throw new NotImplementedException();
    }

    public void Annuler()
    {
        throw new NotImplementedException();
    }

    public void AfficherResume()
    {
        throw new NotImplementedException();
    }
}
