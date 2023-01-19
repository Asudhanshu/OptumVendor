using System;
using VendorMachine;
using Xunit;

namespace UnitTest
{
    public class AcceptingProductsTest
    {
        private AcceptingProducts acceptingProducts;
        public AcceptingProductsTest()
        {
            this.acceptingProducts = new AcceptingProducts();
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ChooseProducts_for_AcceptingProducts(int value)
        {
            try
            {
                var product = this.acceptingProducts.ChooseProduct(value);
                if(value == 1)
                {
                    Assert.Equal("Cola", product.Name);
                }
                else if(value == 2)
                {
                    Assert.Equal("Chips", product.Name);
                }
                else if(value == 3)
                {
                    Assert.Equal("Candy", product.Name);
                }
                else
                {
                    Assert.NotEqual("Cola", product.Name);
                }

            }
            catch (Exception e)
            {
                Assert.False(false);
            }
        }
    }
}
