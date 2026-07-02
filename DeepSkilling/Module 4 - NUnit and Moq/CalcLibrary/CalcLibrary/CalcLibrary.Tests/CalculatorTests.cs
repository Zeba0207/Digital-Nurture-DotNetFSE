using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-5, 10, 5)]
        public void Addition_Test(double a, double b, double expected)
        {
            double actual = calculator.Addition(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(20, 10, 10)]
        [TestCase(10, 5, 5)]
        [TestCase(5, 10, -5)]
        public void Subtraction_Test(double a, double b, double expected)
        {
            double actual = calculator.Subtraction(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, 5, 50)]
        [TestCase(2, 3, 6)]
        [TestCase(-2, 5, -10)]
        public void Multiplication_Test(double a, double b, double expected)
        {
            double actual = calculator.Multiplication(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(20, 5, 4)]
        [TestCase(10, 2, 5)]
        public void Division_Test(double a, double b, double expected)
        {
            double actual = calculator.Division(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_Test()
        {
            Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void TestAddAndClear()
        {
            calculator.Addition(10, 20);
            Assert.That(calculator.GetResult, Is.EqualTo(30));

            calculator.AllClear();
            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }
    }
}