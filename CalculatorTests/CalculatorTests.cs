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
        public void Add_returnSum()
        {
            var num1 = 5;
            var num2 = 5;
            Assert.DoesNotThrow(() => { Calculator.Add(num1,num2); });
        }
        [Test]
        public void Subtract_returnSubtraction()
        {
            var num1 = 5;
            var num2 = 10;
            Assert.DoesNotThrow(() => { Calculator.Subtract(num1, num2); });
        }
        [Test]
        public void Multiply_returnMultiply()
        {
            var num1 = 5;
            var num2 = 10;
            Assert.DoesNotThrow(() => { Calculator.Multiply(num1, num2); });
        }
    }
}