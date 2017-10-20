using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio04;

namespace UnitTestProject1
{
    [TestClass]
    public class ComplejoTest
    {
        [TestMethod]
        public void ComplejoEsReal()
        {
            Complejo pComplejo = new Complejo(2, 0);
            Assert.IsTrue(pComplejo.EsReal());
        }
        [TestMethod]
        public void ComplejoEsImaginario()
        {
            Complejo pComplejo = new Complejo(0, 4);
            Assert.IsTrue(pComplejo.EsImaginario());
        }
        [TestMethod]
        public void ComplejoEsIgual()
        {
            Complejo pComplejo1 = new Complejo(2, 0);
            Complejo pComplejo2 = new Complejo(2, 0);
            Assert.IsTrue(pComplejo1.EsIgual(pComplejo2));
        }
        [TestMethod]
        public void ComplejoMagnitud()
        {
            Complejo pComplejo = new Complejo(3, 4);
            Assert.IsTrue(pComplejo.Magnitud == 5);
        }
        [TestMethod]
        public void ComplejoSumar()
        {
            Complejo pComplejo1 = new Complejo(2, 4);
            Complejo pComplejo2 = new Complejo(3, 5);
            Complejo pResultado = new Complejo(5, 9);
            Complejo pComplejo3 = pComplejo1.Sumar(pComplejo2);
            Assert.IsTrue(pComplejo3.EsIgual(pResultado));
        }



    }
}
