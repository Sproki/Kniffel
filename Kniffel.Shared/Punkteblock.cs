namespace Kniffel.Shared;

public class Punkteblock
{
    // Private Attribute
    private Dictionary<Kategorie, int?> punkte;
    
    // Konstruktor
    public Punkteblock()
    {
        punkte = new Dictionary<Kategorie, int?>();
        
        foreach (Kategorie kategorie in Enum.GetValues(typeof(Kategorie)))
        {
            punkte[kategorie] = null; // Noch nicht gewertet
        }
    }
    
    // Public Eigenschaft zu unserem privatem Attribut
    public Dictionary<Kategorie, int?> Punkte
    {
        get { return punkte; }
    }
    
    // Methode
    public bool PunkteSetzen(Kategorie kategorie, int punkte)
    {
        if (this.punkte[kategorie].HasValue)
            return false; // Schon gesetzt → nicht nochmal erlaubt

        this.punkte[kategorie] = punkte;
        return true;
    }
}