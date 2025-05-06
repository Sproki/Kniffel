namespace Kniffel.Shared;

public class Wuerfelbecher
{
    // Private Attribute
    private Wuerfel[] wuerfelListe = new Wuerfel[5];
    private bool[] festgehaltenenWuerfel = new bool[5];
    
    // Konstruktor
    public Wuerfelbecher(int wuerfelAnzahl)
    {
        for (int i = 0; i < wuerfelAnzahl; i++)
        {
            wuerfelListe[i] = new Wuerfel(6);
        }
    }
    
    // Public Eigenschaften zu unseren privaten Attributen
    public Wuerfel[] WuerfelListe
    {
        get { return wuerfelListe; }
    }
    
    public bool[] FestgehaltenenWuerfel
    {
        get { return festgehaltenenWuerfel; }
    }
    
    // Methoden
    public void Wuerfeln()
    {
        for (int i = 0; i < wuerfelListe.Length; i++)
        {
            if (festgehaltenenWuerfel[i] == false)
            {
                wuerfelListe[i].Wuerfeln();
            }
        }
    }

    public void WuerfelFesthalten(int index, bool festhalten)
    {
        festgehaltenenWuerfel[index] = festhalten;
    }
    
    //TODO Was habe ich nochmal mit Augenzahlen im Klassendiagramm gemeint??
}