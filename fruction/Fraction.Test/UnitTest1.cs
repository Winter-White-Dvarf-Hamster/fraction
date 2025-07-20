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
            Assert.IsTrue(actual.ToString() == expected);
        }

        [TestCase("1/2", "1/2", "1/4")]
        [TestCase("1/3", "1/3", "1/9")]
        [TestCase("1/4", "3/4", "3/16")]
        [TestCase("3/5", "2/5", "6/25")]
        [TestCase("2/5", "2/5", "4/25")]
        [TestCase("2/6", "2/4", "1/6")]
        public void FractionMultFractionCorrect(string left, string right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            var f2 = Task4Kaba.Fraction.Parse(right);
            Assert.IsTrue(f1.Mult(f2).ToString() == expected);
        }

        [TestCase("5/2", 1, "7/2")]
        [TestCase("6/3", 1, "3/1")]
        [TestCase("8/4", 1, "3/1")]
        [TestCase("25/5", 1, "6/1")]
        [TestCase("22/11", 1, "3/1")]
        [TestCase("42/21", 1, "3/1")]
        public void FractionSubIntCorrect(string left, int right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            var f2 = new Task4Kaba.Fraction(right, 1);
            Assert.IsTrue(f1.Add(f2).ToString() == expected);
        }

        [TestCase("1/2", 2, "1/4")]
        [TestCase("1/3", 2, "1/6")]
        [TestCase("1/4", 3, "1/12")]
        [TestCase("1/5", 5, "1/25")]
        [TestCase("7/77", 7, "1/11")]
        [TestCase("21/21", 21, "1/1")]
        public void FractionDivIntCorrect(string left, int right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            Assert.IsTrue(f1.Div(right).ToString() == expected);
        }

        [TestCase("1/2", 2, "2/2")]
        [TestCase("1/3", 2, "2/3")]
        [TestCase("1/4", 3, "3/4")]
        [TestCase("3/5", 5, "3/1")]
        [TestCase("3/11", 7, "21/11")]
        [TestCase("2/5", 2, "4/5")]
        public void FractionMultIntCorrect(string left, int right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            Assert.IsTrue(f1.Mult(right).ToString() == expected);
        }
        [TestCase("1/2", "1/2", "1/1")]
        [TestCase("1/3", "1/6", "1/2")]
        [TestCase("3/4", "1/4", "1/1")]
        [TestCase("2/5", "3/5", "1/1")]
        [TestCase("2/3", "2/3", "4/3")]
        [TestCase("2/5", "2/5", "4/5")]
        public void FractionAddCorrect(string left, string right, string expected)
        {
            var f1 = Task4Kaba.Fraction.Parse(left);
            var f2 = Task4Kaba.Fraction.Parse(right);
            Assert.IsTrue(f1.Add(f2).ToString() == expected);
        }
    }
}