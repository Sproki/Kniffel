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
}