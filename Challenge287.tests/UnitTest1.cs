using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge287.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvalidInputs()
        {
            Assert.AreNotEqual(0, Program.kaprekar(0));
            Assert.AreNotEqual(0, Program.kaprekar(1111));
            Assert.AreNotEqual(0, Program.kaprekar(1118789791));
            Assert.AreNotEqual(0, Program.kaprekar(-89791));
        }
    }
}
