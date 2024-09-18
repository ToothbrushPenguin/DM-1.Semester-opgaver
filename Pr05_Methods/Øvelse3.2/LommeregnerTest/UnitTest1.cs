using Microsoft.VisualStudio.TestPlatform.TestHost;
using Øvelse3._2;

namespace LommeregnerTest

{
    
    [TestClass]
    public class UnitTest1
    {
        
        Calculator calc = new Calculator();
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(3, calc.Add(1, 2));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(6, calc.Sub(8, 2));
        }

        [TestMethod]
        public void TestDivide1()
        {
            Assert.AreEqual(4, calc.Div(8, 2));
        }

        [TestMethod]
        public void TestDivide2()
        {
            Assert.AreEqual(2.67, Math.Round(calc.Div(8, 3), 2));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(8, calc.Mul(4, 2));
        }

        


    }
}