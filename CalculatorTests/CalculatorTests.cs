using net_calculator_tester;

namespace CalculatorTests
{
    public class CalculatorTests
    {
         
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsPositiveResult()
        {
            float result = Calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsNegativeResult()
        {
            float result = Calculator.Add(-2, -3);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectResult()
        {
            float result = Calculator.Add(-2, 3);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsPositiveResult()
        {
            float result = Calculator.Subtract(3, 2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Subtract_TwoNegativeNumbers_ReturnsNegativeResult()
        {
            float result = Calculator.Subtract(-3, -2);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Subtract_PositiveAndNegativeNumbers_ReturnsCorrectResult()
        {
            float result = Calculator.Subtract(-3, 2);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsPositiveResult()
        {
            float result = Calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_ReturnsPositiveResult()
        {
            float result = Calculator.Multiply(-2, -3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumbers_ReturnsNegativeResult()
        {
            float result = Calculator.Multiply(-2, 3);
            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
            public void Divide_divisionByZero()
            {
                Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
            }
        }
}