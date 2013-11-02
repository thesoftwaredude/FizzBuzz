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
    public class TestSort
    {
        [Test]
        public void TestName()
        {
            var sut = new SortNumbers();
            IEnumerable<int> numbersToSort = new List<int>{14,22,3};
            var result = sut.Sort(numbersToSort);
            var firstNumber = result.ToList().FirstOrDefault();
            Assert.That(firstNumber, Is.EqualTo(3));

        }

        [Test]
        public void TestSecondNumber()
        {
            var sut = new SortNumbers();
            IEnumerable<int> numbersToSort = new List<int> { 14, 22, 3 };
            var result = sut.SecondSort(numbersToSort);
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void TestSecondNumberWithSingleArray()
        {
            var sut = new SortNumbers();
            IEnumerable<int> numbersToSort = new List<int> { 14 };
            var result = sut.SecondSort(numbersToSort);
            Assert.That(result, Is.EqualTo(0));

        }


    }
}
