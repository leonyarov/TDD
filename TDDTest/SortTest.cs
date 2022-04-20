using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDD.Tests
{
    [TestClass()]
    public class SortTest
    {
        [TestMethod("Bubble sort worker by salary")]
        public void BubbleWorkersTest()
        {
            var workers = new Worker[]
            {
                new Worker("1", "n", "f", "m@gmail.com", "058", "box", 123),
                new Worker("2", "n", "f", "m@gmail.com", "058", "box", 2),
                new Worker("3", "n", "f", "m@gmail.com", "058", "box", 22)
            };


            var sorted  = Sort.BubbleWorkers(workers);
            Assert.AreNotSame(0, sorted.Length, "The sorted array should not be empty");
            Assert.AreEqual(workers.Length,sorted.Length,"Array length should be the same after sort");

            var sorted_forced = new Worker[]
            {
                new Worker("2", "n", "f", "m@gmail.com", "058", "box", 2),
                new Worker("3", "n", "f", "m@gmail.com", "058", "box", 22),
                new Worker("1", "n", "f", "m@gmail.com", "058", "box", 123),
            };

            CollectionAssert.AreEqual(sorted_forced,sorted);
        }

        [TestMethod()]
        public void QuickWorkersTest()
        {
            Assert.Fail();
        }
    }
}