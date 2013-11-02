using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        [TestCase(5, "Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(7, "7")]
        public void TestFizzBuzzCalculate(int actual, string expected)
        {
            var sut = new FizzBuzz();
            var result = sut.Calculate(actual);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
