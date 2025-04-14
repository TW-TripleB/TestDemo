using NUnit.Framework;
using App;

namespace App.Tests
{
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_2And3_Returns5()
        {
            var result = calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));  // ✅ 檢查這行！
        }

        [Test]
        public void Multiply_3And4_Returns12()
        {
            var result = calc.Multiply(3, 4);
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Subtract_10And7_Returns3()
        {
            var result = calc.Subtract(10, 7);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
