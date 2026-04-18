namespace RefugePourAnimaux;

public class DossierMedical
{
    private int _id;
    private DateTime _dateVisite;
    private string _diagnostic;
    private string _traitement;
    private string _observations;

    public DossierMedical(int id, DateTime dateVisite, string diagnostic, string traitement, string observations)
    {
        _id = id;
        _dateVisite = dateVisite;
        _diagnostic = diagnostic;
        _traitement = traitement;
        _observations = observations;
    }

    public int Id => _id;
    public DateTime DateVisite => _dateVisite;
    public string Diagnostic => _diagnostic;
    public string Traitement => _traitement;
    public string Observations => _observations;

    public void AjouterObservation()
    {
        throw new NotImplementedException();
    }

    public void AfficherDossier()
    {
        throw new NotImplementedException();
    }
}
