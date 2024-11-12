using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_10_22_Tesztelesi
{
    [TestFixture]
    internal class Calculator_test
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
             calculator = new Calculator();
        }

        [Test]
        public void Calculator_AddTestCorrectResult()
        {
            //Arrange
            int a = 12; int b = 17;

            //Act
            int output = calculator.Add(a, b);

            //Assert
            ClassicAssert.AreEqual(29, output);
        }

        [Test]
        public void Calculator_SubtractTestCorrectResult([Values(-32, 12, 500, 98756)] int a, [Values(-568, 2, 456, 9151)] int b)
        {
            try
            {
                int output = calculator.Substract(a,b);
                ClassicAssert.AreEqual(a - b,output);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Hiba");
                return;
            }
        }

        [TestCase(2,3,6)]
        [TestCase(0,5456,0)]
        [TestCase(-23,-1,23)]
        [TestCase(0,0,0)]
        public void Calculator_MultiplyTestCorrectResult(int a , int b , int expect)
        {
            int output = calculator.Multiply(a,b);
            ClassicAssert.AreEqual(expect, output);
        }

        [TestCaseSource(nameof(GetAdditionTestCases))]
        public void Calculator_AddTest_WhenCalled(int a, int b, int expect)
        {
            int output = calculator.Add(a,b);
            ClassicAssert.AreEqual(expect, output);
        }

        public static IEnumerable<TestCaseData> GetAdditionTestCases()
        {
            yield return new TestCaseData(2, 3, 5);
            yield return new TestCaseData(-1, -2, -3);
            yield return new TestCaseData(0, 0, 0);
        }

        [Test]
        public void Calculator_DivideTestByZero()
        {
            Assert.Throws<BarmiAkarmiException>(()=> calculator.Divide(6, 0));
        } 

        [TearDown]
        public void TearDown() { calculator = null; }
    }
}
