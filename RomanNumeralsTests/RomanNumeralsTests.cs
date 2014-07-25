using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        private readonly RomanConverter converter;

        public RomanNumeralsTests()
        {
            converter = new RomanConverter();
        }

        [Test]
        public void Given1_ItShouldReturnI()
        {
            var result = converter.Convert(1);

            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void Given5_ItShouldReturnV()
        {
            var result = converter.Convert(5);

            Assert.That(result, Is.EqualTo("V"));
        }

        [Test]
        public void Given10_ItShouldReturnX()
        {
            var result = converter.Convert(10);

            Assert.That(result, Is.EqualTo("X"));
        }

        [Test]
        public void Given50_ItShouldReturnL()
        {
            var result = converter.Convert(50);

            Assert.That(result, Is.EqualTo("L"));
        }

        [Test]
        public void Given100_ItShouldReturnC()
        {
            var result = converter.Convert(100);

            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void Given500_ItShouldReturnD()
        {
            var result = converter.Convert(500);

            Assert.That(result, Is.EqualTo("D"));
        }

        [Test]
        public void Given1000_ItShouldReturnM()
        {
            var result = converter.Convert(1000);

            Assert.That(result, Is.EqualTo("M"));
        }

        [Test]
        public void Given2_ItShouldReturnII()
        {
            var result = converter.Convert(2);

            Assert.That(result, Is.EqualTo("II"));
        }

        [Test]
        public void Given6_ItShouldReturnVI()
        {
            var result = converter.Convert(6);

            Assert.That(result, Is.EqualTo("VI"));
        }

        [Test]
        public void Given4_ItShouldReturnIV()
        {
            var result = converter.Convert(4);

            Assert.That(result, Is.EqualTo("IV"));
        }

        [Test]
        public void Given9_ItShouldReturnIX()
        {
            var result = converter.Convert(9);

            Assert.That(result, Is.EqualTo("IX"));
        }

        [Test]
        public void Given11_ItShouldReturnXI()
        {
            var result = converter.Convert(11);

            Assert.That(result, Is.EqualTo("XI"));
        }

        [Test]
        public void Given321_ItShouldReturnCCCXXI()
        {
            var result = converter.Convert(321);

            Assert.That(result, Is.EqualTo("CCCXXI"));
        }

        [Test]
        public void Given14_ItShouldReturnXIV()
        {
            var result = converter.Convert(14);

            Assert.That(result, Is.EqualTo("XIV"));
        }

        [Test]
        public void Given19_ItShouldReturnXIX()
        {
            var result = converter.Convert(19);

            Assert.That(result, Is.EqualTo("XIX"));
        }

        [Test]
        public void Given40_ItShouldReturnXL()
        {
            var result = converter.Convert(40);

            Assert.That(result, Is.EqualTo("XL"));
        }

        [Test]
        public void GivenLessThan40_ItShouldReturnOK()
        {
            var values = new Dictionary<int, string>()
                {
                    { 1, "I" },
                    { 2, "II" },
                    { 3, "III" },
                    { 4, "IV" },
                    { 5, "V" },
                    { 6, "VI" },
                    { 7, "VII" },
                    { 8, "VIII" },
                    { 9, "IX" },
                    { 10, "X" },
                    { 11, "XI" },
                    { 12, "XII" },
                    { 13, "XIII" },
                    { 14, "XIV" },
                    { 15, "XV" },
                    { 16, "XVI" },
                    { 17, "XVII" },
                    { 18, "XVIII" },
                    { 19, "XIX" },
                    { 20, "XX" },
                    { 21, "XXI" },
                    { 22, "XXII" },
                    { 23, "XXIII" },
                    { 24, "XXIV" },
                    { 25, "XXV" },
                    { 26, "XXVI" },
                    { 27, "XXVII" },
                    { 28, "XXVIII" },
                    { 29, "XXIX" },
                    { 30, "XXX" },
                    { 31, "XXXI" },
                    { 32, "XXXII" },
                    { 33, "XXXIII" },
                    { 34, "XXXIV" },
                    { 35, "XXXV" },
                    { 36, "XXXVI" },
                    { 37, "XXXVII" },
                    { 38, "XXXVIII" },
                    { 39, "XXXIX" },
                    { 40, "XL" },
                    { 41, "XLI" },
                    { 42, "XLII" },
                    { 43, "XLIII" },
                    { 44, "XLIV" },
                    { 45, "XLV" },
                    { 46, "XLVI" },
                    { 47, "XLVII" },
                    { 48, "XLVIII" },
                    { 49, "XLIX" },
                    { 50, "L" },
                    { 95, "XCV" },
                    { 99, "XCIX" }
                };

            foreach (var pair in values)
            {
                var result = converter.Convert(pair.Key);

                Assert.That(result, Is.EqualTo(pair.Value));
            }
        }
    }
}

