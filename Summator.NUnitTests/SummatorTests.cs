using NUnit.Framework;

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
            var nums = new int[] {-1, -99 };
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
        }

        [Test]
        public void Test_Summator_Avarage()
        {
            var nums = new int[] { 4, 5, 7 };
            var actual = Summator.Avarage(nums);

            var expected = actual;

            Assert.AreEqual(expected, actual);
        }

    }
}