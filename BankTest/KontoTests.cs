using Bank;

namespace BankTest
{
    [TestClass]
    public class KontoTests
    {
       
        [TestMethod]
        public void Konto_KannErstelltWerden()
        {
            // Arrange
            int einzahlen = 20;
            int startwert = 40;
            Konto k = new Konto(startwert);

            // Act
            k.Einzahlen(einzahlen);



            // Assert
            Assert.AreEqual(startwert + einzahlen, k.Guthaben);
        }


    }
}