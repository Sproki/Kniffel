namespace Kniffel.Shared;

public class Wuerfel
{
    // Private Attribute
    private int seiten;
    private int augenzahl;
    
    // Konstruktoren
    public Wuerfel()
    {
        this.seiten = 6;
    }
    
    public Wuerfel(int seiten)
    {
        this.seiten = seiten;
    }
    
    // Public Eigenschaften zu unseren privaten Attributen
    public int Seiten
    {
        get { return seiten; }
    }
    
    public int Augenzahl
    {
        get { return augenzahl; }
    }
    
    // Methoden
    public void Wuerfeln()
    {
        augenzahl = new Random().Next(1, seiten + 1);
    }
}