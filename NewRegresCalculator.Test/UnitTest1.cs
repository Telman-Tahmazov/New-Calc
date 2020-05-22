using New_Regres_Calculator;
using System;
using System.Linq;
using Xunit;

namespace NewRegresCalculator.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3, 5, 8)]
        [InlineData(8, 7, 15)]
        [InlineData(10, 2, 12)]
        [InlineData(10, 8, 18)]


        public void TestSum(double a, double b, double expected)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            double actual = Calk.Sum(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(8, 4, 4)]
        [InlineData(8, 7, 1)]
        [InlineData(10, 2, 8)]
        [InlineData(10, 8, 2)]


        public void TestMin(double a, double b, double expected)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            double actual = Calk.Min(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 5, 15)]
        [InlineData(7, 7, 49)]
        [InlineData(10, 2, 20)]
        [InlineData(5, 8, 40)]


        public void TestMult(double a, double b, double expected)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            double actual = Calk.Mult(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(15, 5, 3)]
        [InlineData(80, 10, 8)]
        [InlineData(10, 2, 5)]
        [InlineData(10, 8, 1.25)]


        public void TestDiv(double a, double b, double expected)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            double actual = Calk.Div(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(25, 5 )]
        [InlineData(121, 11 )]
        [InlineData(144, 12 )]
        [InlineData(196, 14 )]
        [InlineData(225, 15 )]


        public void TestSqrt(double a, double expected)
        {
            SimpleCalculator Calk = new SimpleCalculator();
            double actual = Calk.Sqrt ( a );
            Assert.Equal(expected, actual);
        }
    }
}
