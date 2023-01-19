using System;
using VendorMachine;
using Xunit;

namespace UnitTest
{
    public class AcceptingCoinsTest
    {
        private AcceptingCoins acceptingCoins;
        public AcceptingCoinsTest()
        {
            this.acceptingCoins = new AcceptingCoins();
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void SelectCoin_for_AcceptingCoins(int value)
        {
            try
            {
                this.acceptingCoins.SelectCoin(value);
                Assert.True(true);
            }
            catch (Exception e)
            {
                Assert.False(false);
            }
        }
        [Theory]
        [InlineData(0.2)]
        [InlineData(0.3)]
        public void TotalAmount_for_AcceptingCoins(float value)
        {
            var sum = this.acceptingCoins.TotalAmount(value);
            Assert.Equal(value, sum);
        }
    }
}
