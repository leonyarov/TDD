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
            //To check the actual tax needed to multiply the return value by the salary.
            //Our function is returning the percentage rate so we check if the % rate is correct.
            int salary = 2555;
            double expected = 0.1;
            double result = TDD.Worker.CountTax(salary);

            Assert.AreEqual(expected, result);

            salary = 6000;
            expected = 0.1;

            result = TDD.Worker.CountTax(salary);
            Assert.AreEqual(expected, result);

            salary = 10000;
            expected = 0.2;

            result = TDD.Worker.CountTax(salary);
            Assert.AreEqual(expected, result);

            salary = 13300;
            expected = 0.2;

            result = TDD.Worker.CountTax(salary);
            Assert.AreEqual(expected, result);

            salary = 20000;
            expected = 0.31;

            result = TDD.Worker.CountTax(salary);
            Assert.AreEqual(expected, result);

            salary = 25000;
            expected = 0.35;

            result = TDD.Worker.CountTax(salary);
            Assert.AreEqual(expected, result);

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
            Worker worker1 = new Worker();
            worker1.name = "John";
            worker1.salary = 100;
            worker1.SetSalary(200);
            Assert.AreEqual(worker1.salary, 200);

            Worker worker2 = new Worker();
            worker2.name = "John";
            worker2.salary = 100;
            worker2.SetSalary(200);
            Assert.AreEqual(worker2.salary, 200);
        }

        [TestMethod()]
        public void WorkerClassTest()
        {
            Worker worker1 = new Worker();
            worker1.name = "John";
            worker1.family = "Wick";
            worker1.salary = 100;
            worker1.address = "HaAgana12";
            worker1.email = "john@gmail.com";
            worker1.phone = "054545454";
            
            Assert.AreEqual(worker1.name, "John");
            Assert.AreEqual(worker1.family, "Wick");
            Assert.AreEqual(worker1.salary, 100);
            Assert.AreEqual(worker1.address, "HaAgana12");
            Assert.AreEqual(worker1.email, "john@gmail.com");
            Assert.AreEqual(worker1.phone, "054545454");

        }

    }

   
}