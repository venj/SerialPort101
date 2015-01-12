using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SerialPort101Test {
    [TestClass]
    public class SerialPortTest {
        [TestMethod]
        public void TestTrue() {
            Assert.AreEqual("Hello", "Hello");
        }
    }
}
