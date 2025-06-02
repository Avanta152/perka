using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCanDrive
{
    [TestClass]
    public class UnitTest1
    {
        public bool CanDrive(int age)
        {
            if (age < 0) throw new ArgumentException();
            const int drivingAge = 16;
            return age >= drivingAge;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, CanDrive(15));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, CanDrive(16));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, CanDrive(17));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod4()
        {
            CanDrive(-1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(false, CanDrive(0));
                }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, CanDrive(1));
        }
    }
}
