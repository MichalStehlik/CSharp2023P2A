using CSharp21Testing;

namespace CSharp21Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator(); // Vytvoøí novou kalkulaèku pøed každým testem
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod] // anotace
        public void AdditionTestMethod()
        {
            Assert.AreEqual(2,calc.Addition(1,1));
            Assert.AreEqual(0, calc.Addition(0, 0));
            Assert.AreEqual(-2, calc.Addition(-1, -1));
            Assert.AreEqual(1, calc.Addition(1, 0));
            Assert.AreEqual(1, calc.Addition(0, 1));
            Assert.AreEqual(1000, calc.Addition(100, 900));
        }

        [TestMethod]
        public void DivisionTestMethod()
        {
            Assert.AreEqual(1, calc.Division(1, 1));
            Assert.AreEqual(2, calc.Division(10, 5));
        }

        [TestMethod]
        public void DivisionByZeroTestMethod()
        {
            Assert.ThrowsException<ArgumentException>(() => calc.Division(1,0));
        }
    }
}