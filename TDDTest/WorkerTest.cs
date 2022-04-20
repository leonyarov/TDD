using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDD.Tests
{
    [TestClass()]
    public class WorkerTest
    {
        [TestMethod()]
        public void CountTaxTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var worker1 = new Worker("1", "n", "f", "m@gmail.com", "058", "box", 1);
            var worker2 = new Worker("2", "n", "f", "m@gmail.com", "058", "box", 2);
            var worker3 = new Worker("3", "n", "f", "m@gmail.com", "058", "box", 2);
            Assert.AreEqual(worker1.CompareTo(worker3),-1);
            Assert.AreEqual(worker2.CompareTo(worker3),0);
            Assert.AreEqual(worker3.CompareTo(worker1),1);

        }

        [TestMethod()]
        public void SetSalaryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void WorkerClassTest()
        {
            Assert.Fail();
        }

    }
}