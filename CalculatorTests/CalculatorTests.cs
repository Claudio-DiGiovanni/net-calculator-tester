using net_calculator_tester;
using System.Runtime.ConstrainedExecution;

namespace CalculatorTests
{
    public class CalculatorTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-2, -3, -5)]
        [TestCase(-2, 3, 1)]
        public void AddTest(float n1, float n2, float r)
        {
            float result = Calculator.Add(n1, n2);
            Assert.That(result, Is.EqualTo(r));
        }
        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(-2, -3, 1)]
        [TestCase(-2, 3, -5)]
        public void SubtractTest(float n1, float n2, float r)
        {
            float result = Calculator.Subtract(n1, n2);
            Assert.That(result, Is.EqualTo(r));
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-2, -3, 6)]
        [TestCase(-2, 3, -6)]
        public void MultiplyTest(float n1, float n2, float r)
        {
            float result = Calculator.Multiply(n1, n2);
            Assert.That(result, Is.EqualTo(r));
        }

        [Test]
        [TestCase((float)6, (float)3, (float)2)]
        [TestCase((float)-6, (float)-3, (float)2)]
        [TestCase((float)-6, (float)3, (float)-2)]
        public void DivideTest(float n1, float n2, float? r)
        {

            if (n2 == 0) { Assert.Throws<DivideByZeroException>(() => Calculator.Divide(n1, n2)); }
            float result = Calculator.Divide(n1, n2);
            Assert.That(result, Is.EqualTo(r));
            
        }
    }
}