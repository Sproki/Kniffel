using Kniffel.Shared;

namespace Kniffel.Tests;

[TestClass]
public class WuerfelbecherTests
{
    [TestMethod]
    public void Wuerfelbecher_KonstruktorFunktioniertKorrekt()
    {
        // Arrange
        
        // Act
        Wuerfelbecher wuerfelbecher = new Wuerfelbecher(5);
        
        // Assert
        Assert.AreEqual(5, wuerfelbecher.AlleWuerfel.Count());
    }
    
    [TestMethod]
    public void Wuerfeln_jederWurfZwischenEinsUndSechs()
    {
        // Arrange
        
        // Act
        Wuerfelbecher wuerfelbecher = new Wuerfelbecher(5);
        wuerfelbecher.Wuerfeln();
        
        // Assert
        wuerfelbecher.AlleWuerfel.ToList().ForEach(w => Assert.IsTrue(w.Augenzahl >= 1 && w.Augenzahl <= 6));
    }

    [TestMethod]
    public void WuerfelFesthalten_AusgewaehlterWuerfelWirdFestgehalten()
    {
        // Arrange
        int wuerfelIndex = 3;

        // Act
        Wuerfelbecher wuerfelbecher = new Wuerfelbecher(5);
        wuerfelbecher.WuerfelFesthalten(3, true);
        
        // Assert
        for (int i = 0; i < 5; i++)
        {
            if (i == wuerfelIndex)
            {
                Assert.IsTrue(wuerfelbecher.FestgehaltenenWuerfel[i]);
            }
            else
            {
                Assert.IsFalse(wuerfelbecher.FestgehaltenenWuerfel[i]);
            }
        }
    }
}