using System;
using NUnit.Framework;

namespace SimpleApp
{
    public class Counter
    {
        public int[] CountToTen()
        {
            int[] result = new int[10];
            for (int i = 0; i < 10; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }
    }

    [TestFixture]
    public class CounterTests
    {
        private Counter _counter;

        [SetUp]
        public void Setup()
        {
            _counter = new Counter();
        }

        [Test]
        public void CountToTen_ReturnsArrayWithTenElements()
        {
            var result = _counter.CountToTen();

            Assert.That(result.Length, Is.EqualTo(10));
        }

        [Test]
        public void CountToTen_FirstElementIsOne()
        {
            var result = _counter.CountToTen();

            Assert.That(result[0], Is.EqualTo(1));
        }

        [Test]
        public void CountToTen_LastElementIsTen()
        {
            var result = _counter.CountToTen();

            Assert.That(result[9], Is.EqualTo(10));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JP");
        }
    }
}
