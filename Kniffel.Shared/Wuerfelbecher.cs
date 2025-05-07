namespace Kniffel.Shared;

public class Wuerfelbecher
{
    // Private Attribute
    private Wuerfel[] alleWuerfel = new Wuerfel[5];
    private bool[] festgehaltenenWuerfel = new bool[5];
    
    // Konstruktor
    public Wuerfelbecher(int wuerfelAnzahl)
    {
        for (int i = 0; i < wuerfelAnzahl; i++)
        {
            alleWuerfel[i] = new Wuerfel();
        }
    }
    
    // Public Eigenschaften zu unseren privaten Attributen
    public Wuerfel[] AlleWuerfel
    {
        get { return alleWuerfel; }
    }
    
    public bool[] FestgehaltenenWuerfel
    {
        get { return festgehaltenenWuerfel; }
    }
    
    // Methoden
    public void Wuerfeln()
    {
        for (int i = 0; i < alleWuerfel.Length; i++)
        {
            if (festgehaltenenWuerfel[i] == false)
            {
                alleWuerfel[i].Wuerfeln();
            }
        }
    }

    public void WuerfelFesthalten(int index, bool festhalten)
    {
        festgehaltenenWuerfel[index] = festhalten;
    }
}