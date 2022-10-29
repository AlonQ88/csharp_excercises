namespace csharp_excercises.tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void X_Equals_10()
        {
            var decimalValue = RomanToInteger.RomanToDecimal("X");
            Assert.True(decimalValue.Equals(10));
        }

        [Fact]
        public void LX_Equals_60()
        {
            var decimalValue = RomanToInteger.RomanToDecimal("LX");
            Assert.True(decimalValue.Equals(60));
        }

        [Fact]
        public void I_Equals_1()
        {
            var decimalValue = RomanToInteger.RomanToDecimal("I");
            Assert.True(decimalValue.Equals(1));
        }

        [Fact]
        public void XXIV_Equals_24()
        {
            var decimalValue = RomanToInteger.RomanToDecimal("XXIV");
            Assert.True(decimalValue.Equals(24));
        }
    }
}