using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Sub_WorksWithTwoPositiveIntegers()
        {
            var expected = 0;
            var a = 2;
            var b = 2;
            var actual = Sub(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MulTest()
        {
            var expected = 4;
            var a = 2;
            var b = 2;
            var actual = Mul(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Sub_WorksWithTwoNegativeIntegers()
        {
            var expected = -3;
            var a = -5;
            var b = -2;
            var actual = Sub(a, b);
            Assert.Equal(expected, actual);
        }

        
        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(-2, -7, -5)]
        [InlineData(0, 0, 0)]
        public void Sub_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, Sub(n1, n2));
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(35, -7, -5)]
        [InlineData(0, 0, 0)]
        public void Mul_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, Mul(n1, n2));
        }


        // for more see https://xunit.github.io/docs/getting-started/netcore/cmdline

        int Sub(int x, int y)
        {
            return x - y;
        }
        
        int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
