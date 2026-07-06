using NUnit.Framework;
using Moq;
using ConverterLib;
using CurrencyConverterApp;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Converter converter;
        private Mock<IDollarToEuroExchangeRateFeed> mockFeed;

        [SetUp]
        public void Setup()
        {
            mockFeed = new Mock<IDollarToEuroExchangeRateFeed>();

            mockFeed.Setup(x => x.GetActualUSDollarValue())
                    .Returns(0.85);

            converter = new Converter(mockFeed.Object);
        }

        [Test]
        public void USDToEuro_ValidDollar_ReturnsExpectedEuro()
        {
            double result = converter.USDToEuro(100);

            Assert.That(result, Is.EqualTo(85));
        }

        [Test]
        public void KilometerToMile_ValidInput_ReturnsExpectedResult()
        {
            double result = converter.KilometerToMile(1.609);

            Assert.That(result, Is.EqualTo(1).Within(0.01));
        }

        [Test]
        public void KilogramToPound_ValidInput_ReturnsExpectedResult()
        {
            double result = converter.KilogramToPound(1);

            Assert.That(result, Is.EqualTo(2.205));
        }

        [Test]
        public void CelsiusToKelvin_ValidInput_ReturnsExpectedResult()
        {
            double result = converter.CelsiusToKelvin(0);

            Assert.That(result, Is.EqualTo(273.15));
        }

        [Test]
        public void LiterToGallon_ValidInput_ReturnsExpectedResult()
        {
            double result = converter.LiterToGallon(3.785);

            Assert.That(result, Is.EqualTo(1).Within(0.01));
        }
    }
}