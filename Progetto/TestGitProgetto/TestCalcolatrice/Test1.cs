using CalcolatriceLib;

namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.somma(2, 3);
            Assert.AreEqual(5, risultato, 0.0001, "La somma di 2 e 3 dovrebbe essere 5");
        }

        [TestMethod]
        public void TestSommaConZero()
        {
            TestCalcolatrice calcolatrice = new TestCalcolatrice();
            double risultato = calcolatrice.somma(0, 3);
            Assert.AreEqual(3, risultato, "La somma di 0 e 3 dovrebbe essere 3");
        }
    }
}
