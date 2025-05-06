namespace Kniffel.Shared;

public class Spiel
{
    // Private Attribute
    private List<Spieler> spieler;
    private int spielerIndex = 0; // welcher Spieler ist am Zug?
    private int runde = 0;
    
    // Public Eigenschaften zu unseren privaten Attributen
    public List<Spieler> Spieler
    {
        get { return spieler; }
    }
    
    public int SpielerIndex
    {
        get { return spielerIndex; }
    }
    
    public int Runde
    {
        get { return runde; }
    }
    
    // Methoden
    public bool SpielerHinzufuegen(string name)
    {
        foreach (Spieler spieler in spieler)
        {
            if (spieler.Name == name)
            {
                return false;
            }
        }
        
        spieler.Add(new Spieler(name));
        return true;
    }

    public void NaechsterSpieler()
    {
        spielerIndex++;
        runde++;
        if (spielerIndex >= spieler.Count)
        {
            spielerIndex = 0;
        }
    }

    public Spieler ErmittleGewinner()
    {
        Spieler gewinner = null;
        int hoechstePunktzahl = -1;

        foreach (var spieler in Spieler)
        {
            int punkte = spieler.GesamtPunkte();

            if (punkte > hoechstePunktzahl)
            {
                hoechstePunktzahl = punkte;
                gewinner = spieler;
            }
        }
        return gewinner;
    }
}