using NUnit.Framework;
using Task4Kaba;

namespace Fraction.Test
{
    public class Tests
    {
        
        [TestCase("1/2", "1/2")]
        [TestCase("1/3", "1/3")]
        [TestCase("1/4", "1/4")]
        [TestCase("1/5", "1/5")]
        [TestCase("2/11", "2/11")]
        [TestCase("21/111", "21/111")]
        public void FractionParseCorrect(string process, string expected)
        {
            var actual = Task4Kaba.Fraction.Parse(process);
            Assert.IsTrue(process==expected);
        }

        [TestCase("1/2", "1/2", "1/4")]
        [TestCase("1/3", "1/3", "1/9")]
        [TestCase("1/4", "3/4", "3/16")]
        [TestCase("3/5", "2/5", "6/25")]
        [TestCase("3/11", "7/11", "21/121")]
        [TestCase("21/25", "21/25", "441/625")]
        public void FractionMultFractionCorrect(string left, string right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            var f2 = Task4Kaba.Fraction.Parse(right);
            Assert.IsTrue(f1.Mult(f2).ToString() == expected);
        }

        [TestCase("1/2", 2, "2/2")]
        [TestCase("1/3", 2, "2/3")]
        [TestCase("1/4", 3, "3/4")]
        [TestCase("3/5", 5, "15/5")]
        [TestCase("3/11", 7, "21/11")]
        [TestCase("21/25", 21, "441/25")]
        public void FractionMultIntCorrect(string left, int right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            Assert.IsTrue(f1.Mult(right).ToString() == expected);
        }
    }
}