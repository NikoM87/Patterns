using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceGame.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator;

        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void TestOneCombinations()
        {
            int scope = calculator.Run( new int[] { 1, 0, 0, 0, 0 } );
            Assert.AreEqual( 100, scope );

            scope = calculator.Run( new int[] { 0, 5, 0, 0, 0 } );
            Assert.AreEqual( 50, scope );
        }

        [TestMethod]
        public void TestTheeCombinations()
        {
            int scope = calculator.Run( new int[] { 1, 1, 1, 0, 0 } );
            Assert.AreEqual( 1000, scope );

            scope = calculator.Run( new int[] { 2, 2, 2, 0, 0 } );
            Assert.AreEqual( 200, scope );

            scope = calculator.Run( new int[] { 3, 3, 3, 0, 0 } );
            Assert.AreEqual( 300, scope );

            scope = calculator.Run( new int[] { 4, 4, 4, 0, 0 } );
            Assert.AreEqual( 400, scope );

            scope = calculator.Run( new int[] { 5, 5, 5, 0, 0 } );
            Assert.AreEqual( 500, scope );

            scope = calculator.Run( new int[] { 6, 6, 6, 0, 0 } );
            Assert.AreEqual( 600, scope );
        }

        [TestMethod]
        public void TestMixCombinations()
        {
            int scope = calculator.Run( new int[] { 1, 1, 1, 5, 1 } );
            Assert.AreEqual( 2050, scope );

            scope = calculator.Run( new int[] { 2, 3, 4, 6, 2 } );
            Assert.AreEqual( 0, scope );

            scope = calculator.Run( new int[] { 3, 4, 5, 3, 3 } );
            Assert.AreEqual( 350, scope );
        }

        [TestMethod]
        public void TestFourCombinations()
        {
            int scope = calculator.Run( new int[] { 1, 1, 1, 1, 0 } );
            Assert.AreEqual( 2000, scope );
        }

        [TestMethod]
        public void TestFiveCombinations()
        {
            int scope = calculator.Run( new int[] { 1, 1, 1, 1, 1 } );
            Assert.AreEqual( 4000, scope );

            scope = calculator.Run( new int[] { 1, 2, 3, 4, 5 } );
            Assert.AreEqual( 8000, scope );

            scope = calculator.Run( new int[] { 2, 3, 4, 5, 6 } );
            Assert.AreEqual( 8000, scope );
        }
    }
}
