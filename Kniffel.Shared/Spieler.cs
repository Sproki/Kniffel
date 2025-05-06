namespace Kniffel.Shared;

public class Spieler
{
    // Private Attribute
    private string name;
    private Punkteblock punkteblock;
    private Wuerfelbecher wuerfelbecher;
    
    // Konstruktor
    public Spieler(string name)
    {
        this.name = name;
        punkteblock = new Punkteblock();
        wuerfelbecher = new Wuerfelbecher(5);
    }
    
    // Public Eigenschaften zu unseren privaten Attributen
    public string Name
    {
        get { return name; }
    }
    
    public Punkteblock Punkteblock
    {
        get { return punkteblock; }
    }
    
    public Wuerfelbecher Wuerfelbecher
    {
        get { return wuerfelbecher; }
    }
    
    // Methode
    public int GesamtPunkte()
    {
        int summe = 0;

        foreach (var eintrag in Punkteblock.Punkte)
        {
            if (eintrag.Value.HasValue)
            {
                summe += eintrag.Value.Value;
            }
        }
        
        return summe;
    }
}