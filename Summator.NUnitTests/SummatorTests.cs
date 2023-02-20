using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.IO;

namespace Summator.NUnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            //Act
            var expected = 3;

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            //var array = Array.Empty<int>();
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 1000000000, 1000000000, 1000000000 };
            var actual = Summator.Sum(nums);

            var expected = 3000000000;

            Assert.AreEqual(expected, actual);

            //Constraints

            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void AssertionsExample()
        {
            //Assert boolean condition

            Assert.That(9 == 9);

            Assert.That(9, Is.GreaterThan(6));


            //Range Assertions

            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));


            //String assertions

            Assert.That("I want to become the best QA", Does.Contain("QA"));


            //Asseetions by regex matching

            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));


            //Assertions for expected exception
            Assert.That(() => "abc"[45], Throws.InstanceOf<Exception>());
            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());

            //Assert.That(() => Summator.Sum(new int[] { 1000000000 , 1000000000, 1000000000 }, Throws.TypeOf<IndexOutOfRangeExceptio>));


            //Collection assertions
            Assert.That(new int[] { 4, 5, 6 }, Has.Member(6));


            //Collection range assertions
            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));


            ////File / directory assertions
            //Assert.That(string filePath, Does.Exist);
            Assert.That("C:\\Users\\User\\Desktop\\Links.txt", Does.Exist);

            //DirectoryAssert.Exists(string path);


            //Messages are very important
            //Assert.That(percentage, Is.EqualTo(100), "DDS-to koeto se vrysta");

        }

        [Test]
        public void Test_Summator_Average()
        {
            var nums = new int[] { 4, 5, 7 };
            var actual = Summator.Average(nums);

            var expected = actual;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoPositiveIntNumbers()
        {
            //Arrange
            var nums = new int[] { 3, 5 };
            var actual = Summator.Average(nums);

            //Act
            var expected = 4;

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_AverageTwoPositiveDoubleNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2 };
            var actual = Summator.Average(nums);

            //Act
            var expected = 1.5;

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] {  - 3, -8}, -11)]
        [TestCase(new int[] { 5, 0 }, 5)]
        [TestCase(new int[] { }, 0)]
        
        public void Test_Summator_SumDDT(int[] values, long expected)
        {
            var actual = Summator.Sum(values);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}