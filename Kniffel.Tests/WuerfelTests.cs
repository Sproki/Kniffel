using Kniffel.Shared;

namespace Kniffel.Tests;

[TestClass]
public class WuerfelTests
{
    [TestMethod]
    public void Wuerfel_StandardWuerfelMitSechsSeiten()
    {
        // Arrange
        
        // Act
        Wuerfel wuerfel = new Wuerfel();
        
        // Assert
        Assert.AreEqual(6, wuerfel.Seiten);
        Assert.AreEqual(0, wuerfel.Augenzahl);
    }

    [TestMethod]
    public void Wuerfel_WuerfelMit12Seiten()
    {
        // Arrange
        
        // Act
        Wuerfel wuerfel = new Wuerfel(12);
        
        // Assert
        Assert.AreEqual(12, wuerfel.Seiten);
        Assert.AreEqual(0, wuerfel.Augenzahl);
    }

    [TestMethod]
    public void Wuerfel_SeitenZahlWirdKorrektZurueckGegeben()
    {
        // Arrange
        
        // Act
        Wuerfel wuerfel = new Wuerfel(12);
        
        // Assert
        Assert.AreEqual(12, wuerfel.Seiten);
    }

    [TestMethod]
    public void Wuerfel_AugenzahlWirdKorrektZurueckGegeben()
    {
        // Arrange
        
        // Act
        Wuerfel wuerfel = new Wuerfel();
        
        // Assert
        Assert.AreEqual(0, wuerfel.Augenzahl);
    }
    
    [TestMethod]
    public void Wuerfeln_jederWurfZwischenEinsUndSechs()
    {
        // Arrange
        
        // Act
        Wuerfel wuerfel = new Wuerfel();
        wuerfel.Wuerfeln();
        
        // Assert
        Assert.IsTrue(wuerfel.Augenzahl >= 1 && wuerfel.Augenzahl <= 6);
    }
}